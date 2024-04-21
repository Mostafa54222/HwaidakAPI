using AutoMapper;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.DTOs;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HwaidakAPI.DTOs.Responses.ContactUs;

namespace HwaidakAPI.Controllers
{
    public class ContactUsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ContactUsController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetRestaurantsList>> GetHotelContactUs(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));
            
            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelContactTitle,
                PageBannerPC = _configuration["ImagesLink"] + hotel.HotelContactBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelContactBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelContactBannerTablet,
                PageText = hotel.HotelContact,
                PageMetatagTitle = hotel.HotelContactMetaTagTitle,
                PageMetatagDescription = hotel.HotelContactMetatagDescription
            };

            var contactsDto = _mapper.Map<GetContactHotel>(hotel);



            ContactResponse model = new()
            {
                PageDetails = pagedetails,
                ContactDetails = contactsDto
            };


            return Ok(model);
        }

    }
}
