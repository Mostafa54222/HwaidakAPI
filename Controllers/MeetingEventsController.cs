using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.MeetingEvents;
using HwaidakAPI.Errors;
using HwaidakAPI.Helpers.Profiles.MeetingEvent;
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
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.LangId == language.LangId).ToListAsync();
            var meetingEventDto = _mapper.Map<IEnumerable<GetMeetingEvent>>(meetingEvent);
            return Ok(meetingEventDto);
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetMeetingEventWithPageDetails>>> GetMeetingEventsByHotel(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));

            
            var meetingEventwithPageDetails = await _context.VwHotels.Where(x => x.HotelId == hotel.HotelId && x.LangId == language.LangId).FirstOrDefaultAsync();
            var meetingEventWithPageDetailsDto = _mapper.Map<GetMeetingEventWithPageDetails>(meetingEventwithPageDetails);
            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.HotelId == hotel.HotelId && x.LangId == language.LangId).ToListAsync();
            var meetingEventDto = _mapper.Map<List<GetMeetingEvent>>(meetingEvent);

            meetingEventWithPageDetailsDto.MeetingEvent = meetingEventDto;
            return Ok(meetingEventWithPageDetailsDto);
        }

        [HttpGet("getMeetingEventDetails{languageCode}/{FacilityID}")]
        public async Task<ActionResult<IEnumerable<GetMeetingEvent>>> GetMeetingEventsDetails(int FacilityID, string languageCode = "en")
        {
           

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.FacilityId == FacilityID && x.LangId == language.LangId).FirstOrDefaultAsync();
            var meetingEventDto = _mapper.Map<GetMeetingEvent>(meetingEvent);
            var meetingEventGallery = await _context.VwMeetingsEventsGalleries.Where(x => x.FacilitiesId == FacilityID).ToListAsync();
            var meetingEventGallerydto = _mapper.Map<List<GetMeetingEventsGallery>>(meetingEventGallery);
            meetingEventDto.MeetingEventGallery = meetingEventGallerydto;
            return Ok(meetingEventDto);
        }
    }
}
