using AutoMapper;
using HwaidakAPI.DTOs;
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


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetRestaurantsList>> GetHotelRestaurants(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var restaurants = await _context.VwRestaurants.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelUrl && x.RestaurantStatus==true &&x.IsDeleted==false).ToListAsync();

            var restaurantDto = _mapper.Map<List<GetRestaurant>>(restaurants);


            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelDiningTitle,
                PageBannerPC = hotel.HotelDiningBanner,
                PageBannerMobile = hotel.HotelDiningBannerMobile,
                PageBannerTablet = hotel.HotelDiningBannerTablet,
                PageText = hotel.HotelDining,
                PageMetatagTitle = hotel.HotelDiningMetatagTitle,
                PageMetatagDescription = hotel.HotelDiningMetatagDescription
            };

            GetRestaurantsList model = new GetRestaurantsList
            {
                PageDetails = pagedetails,
                RestauransList = restaurantDto
            };

            return Ok(model);
        }


        [HttpGet("RestaurantDetails/{languageCode}/{hotelUrl}/{restaurantUrl}")]
        public async Task<ActionResult<GetRestaurantDetails>> GetRestaurantDetails(string hotelUrl, string restaurantUrl, string languageCode = "en")
        {

            var restaurantdetails = await _context.VwRestaurants.Where(x => x.HotelUrl == hotelUrl && x.RestaurantUrl == restaurantUrl && x.LanguageAbbreviation == languageCode && x.RestaurantStatus == true &&x.IsDeleted==false).FirstOrDefaultAsync();
            var restaurantgallery = await _context.VwRestaurantsGalleries.Where(x => x.RestaurantId == restaurantdetails.RestaurantId && x.PhotoStatus == true).OrderBy(x => x.PhotoPosition).ToListAsync();
            var otherrestaurant = await _context.VwRestaurants.Where(x => x.HotelUrl == hotelUrl && x.RestaurantUrl != restaurantUrl && x.LanguageAbbreviation == languageCode && x.RestaurantStatus == true &&x.IsDeleted==false).ToListAsync();
            var restaurantDto = _mapper.Map<GetRestaurantDetails>(restaurantdetails);


            restaurantDto.OtherRestaurants = otherrestaurant != null ? _mapper.Map<List<GetRestaurant>>(otherrestaurant) : null;



            return Ok(restaurantDto);
        }
    }
}
