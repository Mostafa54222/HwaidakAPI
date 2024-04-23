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
                facility.FacilityPhotoHome = _configuration["ImagesLink"] + facility.FacilityPhotoHome;
            }

            GetFacilityList model = new()
            {
                PageDetails = pagedetails,
                Facilities = facilitiesDto
            };


            return Ok(model);
        }


        [HttpGet("{languageCode}/{hotelUrl}/{facilityUrl}")]
        public async Task<ActionResult<GetFacilityDetails>> GetRestaurantDetails(string hotelUrl, string facilityUrl, string languageCode = "en")
        {
            var facilityDetails = await _context.VwFacilities.Where(x => x.HotelUrl == hotelUrl && x.FacilityUrl == facilityUrl && x.LanguageAbbreviation == languageCode && x.FacilityStatus == true && x.IsDeleted == false).FirstOrDefaultAsync();
            var facilityGallery = await _context.FacilitiesGalleries.Where(x => x.FacilitiesId == facilityDetails.FacilityId && x.PhotoStatus == true).OrderBy(x => x.PhotoPosition).ToListAsync();
            var otherfacilities = await _context.VwFacilities.Where(x => x.HotelUrl == hotelUrl && x.FacilityUrl != facilityUrl && x.LanguageAbbreviation == languageCode && x.FacilityStatus == true && x.IsDeleted == false).ToListAsync();
            var facilityDto = _mapper.Map<GetFacilityDetails>(facilityDetails);

            facilityDto.FacilityPhoto = _configuration["ImagesLink"] + facilityDto.FacilityPhoto;
            facilityDto.FacilityBanner = _configuration["ImagesLink"] + facilityDto.FacilityBanner;
            facilityDto.FacilityBannerMobile = _configuration["ImagesLink"] + facilityDto.FacilityBannerMobile;
            facilityDto.FacilityBannerTablet = _configuration["ImagesLink"] + facilityDto.FacilityBannerTablet;



            facilityDto.OtherFacility = otherfacilities != null ? _mapper.Map<List<GetFacility>>(otherfacilities) : null;
            facilityDto.FacilityGallery = facilityGallery != null ? _mapper.Map<List<GetFacilityGallery>>(facilityGallery) : null;





            if (facilityDto.OtherFacility != null)
            {
                foreach (var otherr in facilityDto.OtherFacility)
                {
                    otherr.FacilityPhotoHome = _configuration["ImagesLink"] + otherr.FacilityPhotoHome;
                }
            }
            if (facilityDto.FacilityGallery != null)
            {

                foreach (var facilityG in facilityDto.FacilityGallery)
                {
                    facilityG.PhotoFile = _configuration["ImagesLink"] + facilityG.PhotoFile;
                }
            }


            return Ok(facilityDto);
        }

    }
}
