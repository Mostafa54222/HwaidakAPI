using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.MeetingEvents;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<GetMeetingEvent>>> GetMeetingEventsByHotel(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var meetingEvent = await _context.VwMeetingsEvents.Where(x => x.HotelId == hotel.HotelId && x.LangId == language.LangId).FirstOrDefaultAsync();
            var meetingEventDto = _mapper.Map<GetMeetingEvent>(meetingEvent);
            var meetingEventGallery = await _context.VwMeetingsEventsGalleries.Where(x => x.HotelId == hotel.HotelId).ToListAsync();
            var meetingEventGallerDto = _mapper.Map<List<GetMeetingEventsGallery>>(meetingEventGallery);
            meetingEventDto.MeetingEventGallery = meetingEventGallerDto;
            return Ok(meetingEventDto);
        }
    }
}
