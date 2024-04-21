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
        private readonly IConfiguration _configuration;

        public RestaurantController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetRestaurantsList>> GetHotelRestaurants(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var restaurants = await _context.VwRestaurants.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelUrl && x.RestaurantStatus==true &&x.IsDeleted==false).ToListAsync();

            var restaurantDto = _mapper.Map<List<GetRestaurant>>(restaurants);


            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelDiningTitle,
                PageBannerPC = _configuration["ImagesLink"] +  hotel.HotelDiningBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelDiningBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelDiningBannerTablet,
                PageText = hotel.HotelDining,
                PageMetatagTitle = hotel.HotelDiningMetatagTitle,
                PageMetatagDescription = hotel.HotelDiningMetatagDescription
            };

            foreach (var rest in restaurantDto)
            {
                rest.RestaurantPhoto = _configuration["ImagesLink"] + rest.RestaurantPhoto;
                rest.RestaurantsTypePhoto = _configuration["ImagesLink"] + rest.RestaurantsTypePhoto;
            }



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

            restaurantDto.RestaurantPhoto = _configuration["ImagesLink"] + restaurantDto.RestaurantPhoto;
            restaurantDto.RestaurantsTypePhoto = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypePhoto;
            restaurantDto.RestaurantBanner = _configuration["ImagesLink"] + restaurantDto.RestaurantBanner;
            restaurantDto.RestaurantBannerTablet = _configuration["ImagesLink"] + restaurantDto.RestaurantBannerTablet;
            restaurantDto.RestaurantBannerMobile = _configuration["ImagesLink"] + restaurantDto.RestaurantBannerMobile;
            restaurantDto.RestaurantsTypeBanner = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypeBanner;
            restaurantDto.RestaurantsTypeBannerMobile = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypeBannerMobile;
            restaurantDto.RestaurantsTypeBannerTablet = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypeBannerTablet;



            restaurantDto.OtherRestaurants = otherrestaurant != null ? _mapper.Map<List<GetRestaurant>>(otherrestaurant) : null;
            restaurantDto.RestaurantGalleries = restaurantgallery != null ? _mapper.Map<List<GetRestaurantGallery>>(restaurantgallery) : null;





            if (restaurantDto.OtherRestaurants != null)
            {
                foreach (var otherr in restaurantDto.OtherRestaurants)
                {
                    otherr.RestaurantPhoto = _configuration["ImagesLink"] + otherr.RestaurantPhoto;
                    otherr.RestaurantsTypePhoto = _configuration["ImagesLink"] + otherr.RestaurantsTypePhoto;
                }
            }
            if (restaurantDto.RestaurantGalleries != null)
            {

                foreach (var roomgalleries in restaurantDto.RestaurantGalleries)
                {
                    roomgalleries.PhotoFile = _configuration["ImagesLink"] + roomgalleries.PhotoFile;
                }
            }


            return Ok(restaurantDto);
        }
    }
}
