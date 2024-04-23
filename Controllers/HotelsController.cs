using AutoMapper;
using HwaidakAPI.DTOs.Responses.ContactUs;
using HwaidakAPI.DTOs.Responses.Facilities;
using HwaidakAPI.DTOs.Responses.Group;
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
            if (hotelDtos != null)
            {
                foreach (var hotel in hotelDtos)
                {
                    hotel.HotelPhoto = _configuration["ImagesLink"] + hotel.HotelPhoto;
                    hotel.HotelLogoColored = _configuration["ImagesLink"] + hotel.HotelLogoColored;
                }
            }

            return Ok(hotelDtos);
        }

        [HttpGet("{languageCode}/{hotelurl}")]
        public async Task<ActionResult<GetHotel>> GetHotel(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelurl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));
            var languages = await _context.MasterLanguages.ToListAsync();
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));

            var sliders = await _context.TblSliders.Where(x => x.LangId == language.LangId && x.SliderStatus == true && x.IsDeleted == false && x.HotelId == hotel.HotelId).OrderBy(x => x.SliderPosition).ToListAsync();
            var slidersDto = _mapper.Map<List<GetSliders>>(sliders);


            var homeContent = await _context.VwHomes.Where(x => x.LanguageAbbreviation == languageCode && x.HotelId == hotel.HotelId).FirstOrDefaultAsync();




            var facilities = await _context.VwFacilities.Where(x => x.LanguageAbbreviation == languageCode && x.HotelUrl == hotelurl && x.FacilityStatus == true && x.IsDeleted == false).ToListAsync();
            var hotelRooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.RoomStatus == true).OrderBy(x => x.RoomPosition).ToListAsync();
            var hotelNews = await _context.VwNews.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.NewsStatus == true).ToListAsync();
            var hotelNearBy = await _context.VwHotelsNearBies.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.HotelNearByStatus == true).ToListAsync();


            var hotelDto = _mapper.Map<GetHotel>(hotel);


            hotelDto.HotelPhoto = _configuration["ImagesLink"] + hotelDto.HotelPhoto;
            if(homeContent != null)
            {
                hotelDto.SectionWelcomeTitle1 = homeContent.SectionWelcomeTitle1;
                hotelDto.SectionWelcomeTitle2 = homeContent.SectionWelcomeTitle2;
                hotelDto.SectionWelcomeTitleText = homeContent.SectionWelcomeTitleText;
                hotelDto.SectionRoomTitleBack = homeContent.SectionRoomTitleBack;
                hotelDto.SectionRoomTitle = homeContent.SectionRoomTitle;
                hotelDto.SectionRoomText = homeContent.SectionRoomText;
                hotelDto.SectionNewsTitle = homeContent.SectionNewsTitle;
                hotelDto.SectionNewsText = homeContent.SectionNewsText;
                hotelDto.SectionActivitiesTitle = homeContent.SectionActivitiesTitle;
                hotelDto.SectionActivitiesText = homeContent.SectionActivitiesText;

            }


            hotelDto.Sliders = slidersDto != null ? _mapper.Map<List<GetSliders>>(slidersDto) : null;
            hotelDto.HotelFacilities = facilities != null ? _mapper.Map<List<GetFacility>>(facilities) : null;
            hotelDto.HotelRooms = hotelRooms != null ? _mapper.Map<List<GetRoom>>(hotelRooms) : null;
            hotelDto.HotelNews = hotelNews != null ? _mapper.Map<List<GetNewsList>>(hotelNews) : null;
            hotelDto.HotelNearBy = hotelNearBy != null ? _mapper.Map<List<GetHotelNearBy>>(hotelNearBy) : null;




            foreach (var news in hotelDto.HotelNews)
            {
                news.NewsDateTime = DateTime.Parse(news.NewsDateTime.ToString()).ToString("dd MMMM yyyy");
            }

            if (hotelDto.HotelFacilities != null)
            {
                foreach (var hotelfacilities in hotelDto.HotelFacilities)
                {
                    hotelfacilities.FacilityPhotoHome = _configuration["ImagesLink"] + hotelfacilities.FacilityPhotoHome;
                }
            }

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

            return Ok(hotelDto);

        }



        [HttpGet("HotelLayout/{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetHotelLayout>> GetHotelLayout(string hotelUrl, string languageCode = "en")
        {
            var languages = await _context.MasterLanguages.ToListAsync();

            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var groupLayout = await _context.TblGroupLayouts.FirstOrDefaultAsync();


            var groupFooterDto = _mapper.Map<GetGroupFooter>(groupLayout);



            GetHotelLayout model = new()
            {
                HotelHeader = _mapper.Map<GetHotelHeader>(hotel),
                HotlFooter = _mapper.Map<GetHotelFooter>(hotel)
            };
            model.HotelHeader.ButtonGroupUrl = _configuration["ButtonGroupUrl"];
            model.HotlFooter.GroupLogo = _configuration["ImagesLink"] + groupFooterDto.GroupLogo;
            model.HotelHeader.HotelLogo = _configuration["ImagesLink"] + model.HotelHeader.HotelLogo;
            model.HotelHeader.HotelLogoColored = _configuration["ImagesLink"] + model.HotelHeader.HotelLogoColored;

            foreach (var lang in languages)
            {
                model.HotelHeader.Languages.Add(new LanguageResponse
                {
                    LanguageName = lang.LanguageName,
                    LanguageAbbreviation = lang.LanguageAbbreviation
                });
            }

            return Ok(model);
        }

    }
}
