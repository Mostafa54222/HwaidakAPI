using AutoMapper;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.DTOs.Responses.Rooms;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class RestaurantController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public RestaurantController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }




        [HttpGet("{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetRestaurant>>> GetRestaurants(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var restaurants = await _context.VwRestaurants.Where(x => x.LangId == language.LangId).ToListAsync();


            var restaurantDto = _mapper.Map<IEnumerable<GetRestaurant>>(restaurants);

            return Ok(restaurantDto);
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetRoom>>> GetHotelRestaurants(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var restaurants = await _context.VwRestaurants.Where(x => x.HotelId == hotel.HotelId).ToListAsync();

            var restaurantDto = _mapper.Map<IEnumerable<GetRoom>>(restaurants);


            return Ok(restaurantDto);
        }
    }
}
