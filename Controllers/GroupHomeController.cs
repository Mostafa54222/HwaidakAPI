using AutoMapper;
using HwaidakAPI.DTOs.Responses.Group;
using HwaidakAPI.DTOs.Responses.Home;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class GroupHomeController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GroupHomeController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("{languageCode}")]
        public async Task<ActionResult<GetGroupResponse>> GetGroupHome(string languageCode = "en")
        {
            var languages = await _context.MasterLanguages.ToListAsync();

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));

            var groupLayout = await _context.TblGroupLayouts.FirstOrDefaultAsync();
            var groupHeaderDto = _mapper.Map<GetGroupHeader>(groupLayout);



            foreach (var lang in languages)
            {
                groupHeaderDto.Languages.Add(new LanguageResponse
                {
                    LanguageName = lang.LanguageName,
                    LanguageAbbreviation = lang.LanguageAbbreviation
                });
            }




            var groupSliders = await _context.TblGroupSliders.Where(x => x.SliderStatus == true && x.IsDeleted == false && x.LangId == language.LangId).ToListAsync();
            var groupSlidersDto = _mapper.Map<List<GetGroupSlider>>(groupSliders);

            var groupHomeIntro = await _context.VwGroupHomeIntros.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            var groupHomeIntroDto = _mapper.Map<GetGroupHomeIntro>(groupHomeIntro);

            var groupHomeIntroActivities = await _context.VwGroupHomeIntroActivities.Where(x => x.LanguageAbbreviation == languageCode && x.GroupHomeActivityStatus == true).OrderBy(x => x.GroupHomeActivityPosition).ToListAsync();
            var groupHomeIntroActivitiesDto = _mapper.Map<List<GetGroupHomeIntroActivities>>(groupHomeIntroActivities);


            var hotels = await _context.VwHotels.Where(x => x.HotelStatus == true && x.LanguageAbbreviation == languageCode).ToListAsync();
            var hotelDtos = _mapper.Map<List<GetHotelList>>(hotels);


            var groupHome = await _context.VwGroupHomes.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            var groupHomeDto = _mapper.Map<GetGroupHome>(groupHome);


            var groupHomeVideo = await _context.VwGroupHomeVideoSections.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            var groupHomeVideoDto = _mapper.Map<GetGroupHomeVideo>(groupHomeVideo);


            var groupFooterDto = _mapper.Map<GetGroupFooter>(groupLayout);
            groupFooterDto.GroupLogo = _configuration["ImagesLink"] + groupFooterDto.GroupLogo;


            if (groupSlidersDto != null)
            {
                foreach (var slider in groupSlidersDto)
                {
                    slider.SliderPhoto = _configuration["ImagesLink"] + slider.SliderPhoto;
                }
            }
            if (hotelDtos != null)
            {
                foreach (var hotel in hotelDtos)
                {
                    hotel.HotelPhoto = _configuration["ImagesLink"] + hotel.HotelPhoto;
                    hotel.HotelLogo = _configuration["ImagesLink"] + hotel.HotelLogo;
                }
            }

            groupHomeDto.GroupHomePhoto1 = _configuration["ImagesLink"] + groupHomeDto.GroupHomePhoto1;
            groupHomeDto.GroupHomePhoto2 = _configuration["ImagesLink"] + groupHomeDto.GroupHomePhoto2;


            groupHomeVideo.GroupHomeVideoSectionBanner = _configuration["ImagesLink"] + groupHomeVideo.GroupHomeVideoSectionBanner;
            groupHomeVideo.GroupHomeVideoSectionBannerMobile = _configuration["ImagesLink"] + groupHomeVideo.GroupHomeVideoSectionBannerMobile;
            groupHomeVideo.GroupHomeVideoSectionBannerTablet = _configuration["ImagesLink"] + groupHomeVideo.GroupHomeVideoSectionBannerTablet;

            GetGroupResponse model = new()
            {
                GroupHeader = groupHeaderDto,
                GroupSliders = groupSlidersDto,
                GroupHomeIntro = groupHomeIntroDto,
                GroupHomeIntroActivities = groupHomeIntroActivitiesDto,
                Hotels = hotelDtos,
                GroupHome = groupHomeDto,
                GroupHomeVideo = groupHomeVideoDto,
                GroupFooter = groupFooterDto

            };

            return Ok(model);
        }
    }
}
