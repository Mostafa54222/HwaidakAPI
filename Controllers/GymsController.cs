using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.DTOs.Responses.Rooms;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class GymsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public GymsController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }




        [HttpGet("{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetGym>>> GetGyms(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var gyms = await _context.VwGyms.Where(x => x.LangId == language.LangId).ToListAsync();
            var gymDto = _mapper.Map<IEnumerable<GetGym>>(gyms);

            return Ok(gymDto);
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetGym>>> GetHotelGyms(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var Gyms = await _context.VwGyms.Where(x => x.HotelId == hotel.HotelId).ToListAsync();

            var restaurantDto = _mapper.Map<IEnumerable<GetGym>>(Gyms);


            return Ok(restaurantDto);
        }

        [HttpGet("GetGymServices/{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetGymService>>> GetGymServices(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var gymservices = await _context.VwGymServices.Where(x => x.LangId == language.LangId).ToListAsync();
            var gymServiceDto = _mapper.Map<IEnumerable<GetGymService>>(gymservices);

            return Ok(gymServiceDto);
        }
    }
}
