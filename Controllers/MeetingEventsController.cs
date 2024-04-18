using AutoMapper;
using HwaidakAPI.DTOs;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.MeetingEvents;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HwaidakAPI.Controllers
{
    public class MeetingEventsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public MeetingEventsController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }




        [HttpGet("{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetMeetingEvent>>> GetMeetingEvents(string languageCode = "en")
        {
            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.LanguageAbbreviation == languageCode && x.FacilityStatus==true && x.IsDeleted==false).ToListAsync();
            var meetingEventDto = _mapper.Map<IEnumerable<GetMeetingEvent>>(meetingEvent);
            return Ok(meetingEventDto);
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetMeetingEventWithPageDetails>>> GetMeetingEventsByHotel(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            // to do the phone and email


            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelMeetingTitle,
                PageBannerPC = hotel.HotelMeetingBanner,
                PageBannerMobile = hotel.HotelMeetingBannerMobile,
                PageBannerTablet = hotel.HotelMeetingBannerTablet,
                PageText = hotel.HotelMeeting,
                PageMetatagTitle = hotel.HotelMeetingMetatagTitle,
                PageMetatagDescription = hotel.HotelMeetingMetatagDescription
            };

            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.FacilityStatus == true).OrderBy(x => x.FacilityPosition).ToListAsync();
            var meetingEventDto = _mapper.Map<List<GetMeetingEvent>>(meetingEvent);
            GetMeetingEventWithPageDetails model = new GetMeetingEventWithPageDetails
            {
                PageDetails = pagedetails,
                MeetingEvent = meetingEventDto
            };

            return Ok(model);
        }

        [HttpGet("getMeetingEventDetails{languageCode}/{hotelUrl}/{FacilityUrl}")]
        public async Task<ActionResult<IEnumerable<GetMeetingEventsDetails>>> GetMeetingEventsDetails(string hotelUrl, string FacilityUrl, string languageCode = "en")
        {

            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.LanguageAbbreviation == languageCode && x.FacilityStatus == true && x.FacilityUrl == FacilityUrl && x.HotelId == hotel.HotelId).OrderBy(x => x.FacilityPosition).FirstOrDefaultAsync();
            var meetingEventDto = _mapper.Map<GetMeetingEventsDetails>(meetingEvent);
            var meetingEventGallery = await _context.VwMeetingsEventsGalleries.Where(x => x.FacilitiesId == meetingEvent.FacilityId).ToListAsync();
            var otherMeetingEvents = await _context.VwMeetingsEvents.Where(x => x.LanguageAbbreviation == languageCode && x.FacilityUrl != FacilityUrl && x.HotelId == hotel.HotelId && x.FacilityStatus == true).OrderBy(x => x.FacilityPosition).ToListAsync();
            var meetingEventGallerydto = _mapper.Map<List<GetMeetingEventsGallery>>(meetingEventGallery);


            meetingEventDto.MeetingEventGallery = meetingEventGallerydto;
            meetingEventDto.OtherMeetingEvents = otherMeetingEvents != null ? _mapper.Map<List<GetMeetingEvent>>(otherMeetingEvents) : null;
            return Ok(meetingEventDto);
        }
    }
}
