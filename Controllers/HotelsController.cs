using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.Home;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.DTOs.Responses.News;
using HwaidakAPI.DTOs.Responses.Rooms;
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
        private readonly IConfiguration _configuration;

        public HotelsController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("{languageCode}")]
        public async Task<ActionResult<List<GetHotelList>>> GetHotels(string languageCode = "en")
        {

            var hotels = await _context.VwHotels.Where(x=>x.HotelStatus == true && x.LanguageAbbreviation == languageCode).ToListAsync();

            var hotelDtos = _mapper.Map<List<GetHotelList>>(hotels);


            return Ok(hotelDtos);
        }

        [HttpGet("{languageCode}/{hotelurl}")]
        public async Task<ActionResult<GetHotel>> GetHotel(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelurl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));

            var sliders = await _context.TblSliders.Where(x => x.LangId == language.LangId && x.SliderStatus == true && x.IsDeleted == false && x.HotelId == hotel.HotelId).OrderBy(x => x.SliderPosition).ToListAsync();
            var slidersDto = _mapper.Map<List<GetSliders>>(sliders);


            var homeContent = await _context.VwHomes.Where(x => x.LanguageAbbreviation == languageCode && x.HotelId == hotel.HotelId).FirstOrDefaultAsync();




            var hotelfacilities = await _context.VwHotelsFacilities.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.HotelFacilitiesItemStatus == true).OrderBy(x => x.HotelFacilitiesItemPosition).ToListAsync();
            var hotelRooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.RoomStatus == true).OrderBy(x => x.RoomPosition).ToListAsync();
            var hotelNews = await _context.VwNews.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.NewsStatus == true).ToListAsync();
            var hotelNearBy = await _context.VwHotelsNearBies.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.HotelNearByStatus == true).ToListAsync();


            var hotelDto = _mapper.Map<GetHotel>(hotel);



            hotelDto.HotelPhoto = _configuration["ImagesLink"] + hotelDto.HotelPhoto;
            hotelDto.HotelLogo = _configuration["ImagesLink"] + hotelDto.HotelLogo;
            hotelDto.SectionWelcomeTitle1 = homeContent.SectionWelcomeTitle1;
            hotelDto.SectionWelcomeTitle2 = homeContent.SectionWelcomeTitle2;
            hotelDto.SectionWelcomeTitleText = homeContent.SectionWelcomeTitleText;

            hotelDto.Sliders = slidersDto != null ? _mapper.Map<List<GetSliders>>(slidersDto) : null;
            hotelDto.HotelFacilities = hotelfacilities != null ? _mapper.Map<List<GetHotelFacilities>>(hotelfacilities) : null;
            hotelDto.HotelRooms = hotelRooms != null ? _mapper.Map<List<GetRoom>>(hotelRooms) : null;
            hotelDto.HotelNews = hotelNews != null ? _mapper.Map<List<GetNewsList>>(hotelNews) : null;
            hotelDto.HotelNearBy = hotelNearBy != null ? _mapper.Map<List<GetHotelNearBy>>(hotelNearBy) : null;



            if (hotelDto.Sliders != null)
            {
                foreach (var hotelsliders in hotelDto.Sliders)
                {
                    hotelsliders.SliderPhoto = _configuration["ImagesLink"] + hotelsliders.SliderPhoto;
                }
            }

            if (hotelDto.HotelRooms != null)
            {
                foreach (var hotelrooms in hotelDto.HotelRooms)
                {
                    hotelrooms.RoomPhotoHome = _configuration["ImagesLink"] + hotelrooms.RoomPhotoHome;
                }
            }
            if (hotelDto.HotelNews != null)
            {
                foreach (var hotelnews in hotelDto.HotelNews)
                {
                    hotelnews.NewsPhoto = _configuration["ImagesLink"] + hotelnews.NewsPhoto;
                }
            }
            if (hotelDto.HotelFacilities != null)
            {
                foreach (var hotelfacilites in hotelDto.HotelFacilities)
                {
                    hotelfacilites.HotelFacilitiesIcon = _configuration["IconsLink"] + hotelfacilites.HotelFacilitiesIcon;
                }
            }

            return Ok(hotelDto);

        }

    }
}
