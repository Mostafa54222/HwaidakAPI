using AutoMapper;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class HotelsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;

        public HotelsController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetHotel>>> GetHotels(string languageCode = "en")
        {
            var hotels = await _context.Hotels.ToListAsync();

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var hotelsContent = await _context.HotelsContents.Where(x => x.LangId == language.LangId).ToListAsync();
            if (hotelsContent == null) return NotFound(new ApiResponse(404, "there is no hotels with this language"));


            var hotelDtos = _mapper.Map<IEnumerable<GetHotel>>(hotels);
            foreach (var hotelDto in hotelDtos)
            {
                var content = hotelsContent.FirstOrDefault(x => x.HotelId == hotelDto.HotelId);
                hotelDto.HotelContent = content != null ? _mapper.Map<GetHotelContent>(content) : null;
            }

            return Ok(hotelDtos);
        }

        [HttpGet("{languageCode}/{hotelurl}")]
        public async Task<ActionResult<IEnumerable<GetHotel>>> GetHotels(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelurl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var hotelContent = await _context.HotelsContents.Where(x => x.LangId == language.LangId && x.HotelId == hotel.HotelId).FirstOrDefaultAsync();

            var hotelDto = _mapper.Map<GetHotel>(hotel);
            hotelDto.HotelContent = hotelContent != null ? _mapper.Map<GetHotelContent>(hotelContent) : null;
            return Ok(hotelDto);

        }


    }
}
