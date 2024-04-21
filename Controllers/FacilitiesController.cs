using AutoMapper;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.DTOs;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HwaidakAPI.DTOs.Responses.Facilities;

namespace HwaidakAPI.Controllers
{
    public class FacilitiesController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public FacilitiesController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetRestaurantsList>> GetHotelFacilites(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var facilities = await _context.VwFacilities.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelUrl && x.FacilityStatus == true && x.IsDeleted == false).ToListAsync();

            var facilitiesDto = _mapper.Map<List<GetFacility>>(facilities);


            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelFacilitiesTitle,
                PageBannerPC = _configuration["ImagesLink"] + hotel.HotelFacilitiesBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelFacilitiesBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelFacilitiesBannerTablet,
                PageText = hotel.HotelFacilities,
                PageMetatagTitle = hotel.HotelFacilitiesMetatagTitle,
                PageMetatagDescription = hotel.HotelFacilitiesMetatagDescription
            };
            foreach (var facility in facilitiesDto)
            {
                facility.FacilityPhoto = _configuration["ImagesLink"] + facility.FacilityPhoto;
            }

            GetFacilityList model = new()
            {
                PageDetails = pagedetails,
                Facilities = facilitiesDto
            };


            return Ok(model);
        }


        //[HttpGet("RestaurantDetails/{languageCode}/{hotelUrl}/{facilityUrl}")]
        //public async Task<ActionResult<GetRestaurantDetails>> GetRestaurantDetails(string hotelUrl, string facilityUrl, string languageCode = "en")
        //{
        //    var facilityDetails = await _context.VwFacilities.Where(x => x.HotelUrl == hotelUrl && x.FacilityUrl == facilityUrl && x.LanguageAbbreviation == languageCode && x.FacilityStatus == true && x.IsDeleted == false).FirstOrDefaultAsync();
        //    var facilityGallery = await _context.FacilitiesGalleries.Where(x => x.FacilitiesId == facilityUrl.RestaurantId && x.PhotoStatus == true).OrderBy(x => x.PhotoPosition).ToListAsync();
        //    var otherrestaurant = await _context.VwRestaurants.Where(x => x.HotelUrl == hotelUrl && x.RestaurantUrl != restaurantUrl && x.LanguageAbbreviation == languageCode && x.RestaurantStatus == true && x.IsDeleted == false).ToListAsync();
        //    var restaurantDto = _mapper.Map<GetRestaurantDetails>(restaurantdetails);

        //    restaurantDto.RestaurantPhoto = _configuration["ImagesLink"] + restaurantDto.RestaurantPhoto;
        //    restaurantDto.RestaurantsTypePhoto = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypePhoto;
        //    restaurantDto.RestaurantBanner = _configuration["ImagesLink"] + restaurantDto.RestaurantBanner;
        //    restaurantDto.RestaurantBannerTablet = _configuration["ImagesLink"] + restaurantDto.RestaurantBannerTablet;
        //    restaurantDto.RestaurantBannerMobile = _configuration["ImagesLink"] + restaurantDto.RestaurantBannerMobile;
        //    restaurantDto.RestaurantsTypeBanner = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypeBanner;
        //    restaurantDto.RestaurantsTypeBannerMobile = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypeBannerMobile;
        //    restaurantDto.RestaurantsTypeBannerTablet = _configuration["ImagesLink"] + restaurantDto.RestaurantsTypeBannerTablet;



        //    restaurantDto.OtherRestaurants = otherrestaurant != null ? _mapper.Map<List<GetRestaurant>>(otherrestaurant) : null;
        //    restaurantDto.RestaurantGalleries = restaurantgallery != null ? _mapper.Map<List<GetRestaurantGallery>>(restaurantgallery) : null;





        //    if (restaurantDto.OtherRestaurants != null)
        //    {
        //        foreach (var otherr in restaurantDto.OtherRestaurants)
        //        {
        //            otherr.RestaurantPhoto = _configuration["ImagesLink"] + otherr.RestaurantPhoto;
        //            otherr.RestaurantsTypePhoto = _configuration["ImagesLink"] + otherr.RestaurantsTypePhoto;
        //        }
        //    }
        //    if (restaurantDto.RestaurantGalleries != null)
        //    {

        //        foreach (var roomgalleries in restaurantDto.RestaurantGalleries)
        //        {
        //            roomgalleries.PhotoFile = _configuration["ImagesLink"] + roomgalleries.PhotoFile;
        //        }
        //    }


        //    return Ok(restaurantDto);
        //}

    }
}
