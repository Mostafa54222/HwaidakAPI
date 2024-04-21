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
        private readonly IConfiguration _configuration;

        public MeetingEventsController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }




        [HttpGet("{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetMeetingEvent>>> GetMeetingEvents(string languageCode = "en")
        {
            
            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.LanguageAbbreviation == languageCode && x.FacilityStatus==true && x.IsDeleted==false).ToListAsync();
            var meetingEventDto = _mapper.Map<IEnumerable<GetMeetingEvent>>(meetingEvent);


            foreach (var meeting in meetingEventDto)
            {
                var hotel = await _context.VwHotels.Where(x => x.HotelId == meeting.HotelId && x.LanguageAbbreviation == languageCode && x.HotelStatus == true).FirstOrDefaultAsync();

                meeting.FacilityPhoto = _configuration["ImagesLink"] + meeting.FacilityPhoto;
                meeting.FacilityPhotoHome = _configuration["ImagesLink"] + meeting.FacilityPhotoHome;
                meeting.HotelUrl = hotel.HotelUrl;
            }
            return Ok(meetingEventDto);
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetMeetingEventWithPageDetails>>> GetMeetingEventsByHotel(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            // to do the phone and email

            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelMeetingTitle,
                PageBannerPC = _configuration["ImagesLink"] + hotel.HotelMeetingBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelMeetingBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelMeetingBannerTablet,
                PageText = hotel.HotelMeeting,
                PageMetatagTitle = hotel.HotelMeetingMetatagTitle,
                PageMetatagDescription = hotel.HotelMeetingMetatagDescription
            };

            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.FacilityStatus == true).OrderBy(x => x.FacilityPosition).ToListAsync();
            var meetingEventDto = _mapper.Map<List<GetMeetingEvent>>(meetingEvent);

            foreach (var meeting in meetingEventDto)
            {
                meeting.FacilityPhoto = _configuration["ImagesLink"] + meeting.FacilityPhoto;
                meeting.FacilityPhotoHome = _configuration["ImagesLink"] + meeting.FacilityPhotoHome;
            }

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

            meetingEventDto.FacilityPhoto = _configuration["ImagesLink"] + meetingEventDto.FacilityPhoto;
            meetingEventDto.FacilityBanner = _configuration["ImagesLink"] + meetingEventDto.FacilityBanner;
            meetingEventDto.FacilityBannerMobile = _configuration["ImagesLink"] + meetingEventDto.FacilityBannerMobile;
            meetingEventDto.FacilityBannerTablet = _configuration["ImagesLink"] + meetingEventDto.FacilityBannerTablet;


            meetingEventDto.MeetingEventGallery = meetingEventGallerydto;
            meetingEventDto.OtherMeetingEvents = otherMeetingEvents != null ? _mapper.Map<List<GetMeetingEvent>>(otherMeetingEvents) : null;




            if (meetingEventDto.MeetingEventGallery != null)
            {
                foreach (var gallery in meetingEventDto.MeetingEventGallery)
                {
                    gallery.PhotoFile = _configuration["ImagesLink"] + gallery.PhotoFile;
                }
            }
            if (meetingEventDto.OtherMeetingEvents != null)
            {

                foreach (var othermeetings in meetingEventDto.OtherMeetingEvents)
                {
                    othermeetings.FacilityPhotoHome = _configuration["ImagesLink"] + othermeetings.FacilityPhotoHome;
                    othermeetings.FacilityPhoto = _configuration["ImagesLink"] + othermeetings.FacilityPhoto;
                }
            }



            return Ok(meetingEventDto);
        }
    }
}
