using AutoMapper;
using HwaidakAPI.DTOs.Responses.Home;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.DTOs.Responses.News;
using HwaidakAPI.DTOs.Responses.SPA;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class HomeController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public HomeController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("GetWholeHomePage/{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetWholeHomePage>>> GetWholeHomePage(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));

            var sliders = await _context.TblSliders.Where(x => x.LangId == language.LangId &&x.SliderStatus==true &&x.IsDeleted==false).ToListAsync();
            var slidersDto = _mapper.Map<List<GetSliders>>(sliders);

            var siteContacts = await _context.TblSiteContacts.Where(x => x.LangId == language.LangId).ToListAsync();
            var siteContactsDto = _mapper.Map<List<GetSiteContacts>>(siteContacts);

            var siteSocails = await _context.TblSiteSocials.ToListAsync();
            var siteSocailsDto = _mapper.Map<List<GetSiteSocials>>(siteSocails);

            var News = await _context.VwNews.ToListAsync();
            var NewsDto = _mapper.Map<List<GetNewsList>>(News);

            var hotels = await _context.VwHotels.Where(x=>x.LangId==language.LangId &&x.HotelStatus==true).ToListAsync();
            var hotelDtos = _mapper.Map<List<GetHotelHome>>(hotels);

            var getWholeHomePageDto = new GetWholeHomePage();
            getWholeHomePageDto.Sliders = slidersDto;
            getWholeHomePageDto.SiteContacts = siteContactsDto;
            getWholeHomePageDto.SiteSocials = siteSocailsDto;
            getWholeHomePageDto.News = NewsDto;
            getWholeHomePageDto.Hotels = hotelDtos;
            

            return Ok(getWholeHomePageDto);
        }

        //[HttpGet("GetSliders/{languageCode}")]
        //public async Task<ActionResult<IEnumerable<GetSliders>>> GetSliders(string languageCode = "en")
        //{
        //    var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
        //    if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
        //    var sliders = await _context.TblSliders.Where(x => x.LangId == language.LangId).ToListAsync();
        //    var slidersDto = _mapper.Map<IEnumerable<GetSliders>>(sliders);

        //    var siteContacts = await _context.TblSiteContacts.Where(x => x.LangId == language.LangId).ToListAsync();
        //    var siteContactsDto = _mapper.Map<IEnumerable<GetSiteContacts>>(siteContacts);

        //    return Ok(slidersDto);
        //}

        //[HttpGet("GetWhyUs/{languageCode}")]
        //public async Task<ActionResult<IEnumerable<GetHomeWhyUs>>> GetWhyUs(string languageCode = "en")
        //{

        //    var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
        //    if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            

        //    var WhyUs= await _context.VwHomeWhyUs.Where(x=>x.LangId==language.LangId).ToListAsync();
        //    var whyUsDto = _mapper.Map<IEnumerable<GetHomeWhyUs>>(WhyUs);
            

        //    return Ok(whyUsDto);
        //}

        //[HttpGet("GetWhyUsByHotel/{languageCode}/{HotelId}")]
        //public async Task<ActionResult<IEnumerable<GetHomeWhyUs>>> GetWhyUsByHotel(int HotelId, string languageCode = "en")
        //{
        //    var hotel = await _context.Hotels.Where(x => x.HotelId == HotelId).FirstOrDefaultAsync();
        //    if (hotel == null) return NotFound(new ApiResponse(404, "this hotel doesnt exist"));

        //    var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
        //    if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


        //    var WhyUs = await _context.VwHomeWhyUs.Where(x => x.LangId == language.LangId && x.HotelId==hotel.HotelId).ToListAsync();
        //    var whyUsDto = _mapper.Map<IEnumerable<GetHomeWhyUs>>(WhyUs);


        //    return Ok(whyUsDto);
        //}
        //[HttpGet("GetSiteContacts/{languageCode}")]
        //public async Task<ActionResult<IEnumerable<GetSiteContacts>>> GetSiteContacts(string languageCode = "en")
        //{
        //    var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
        //    if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
        //    var siteContacts = await _context.TblSiteContacts.Where(x => x.LangId == language.LangId).ToListAsync();
        //    var siteContactsDto = _mapper.Map<IEnumerable<GetSiteContacts>>(siteContacts);

        //    return Ok(siteContactsDto);
        //}

        //[HttpGet("GetSiteSocials")]
        //public async Task<ActionResult<IEnumerable<GetSiteSocials>>> GetSiteSocials()
        //{
        //    var siteSocails = await _context.TblSiteSocials.ToListAsync();
        //    var siteSocailsDto = _mapper.Map<IEnumerable<GetSiteSocials>>(siteSocails);

        //    return Ok(siteSocailsDto);
        //}

        //[HttpGet("GetPages/{languageCode}")]
        //public async Task<ActionResult<IEnumerable<GetPages>>> GetPages(string languageCode = "en")
        //{
        //    var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
        //    if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
        //    var pages = await _context.VwPages.Where(x => x.LangId == language.LangId).ToListAsync();
        //    var pagesDto = _mapper.Map<IEnumerable<GetPages>>(pages);

        //    return Ok(pagesDto);
        //}

        //[HttpGet("GetPageBanners/{PageID}")]
        //public async Task<ActionResult<IEnumerable<GetPages>>> GetPageBanners(int PageID)
        //{
        //    var pageBanners = await _context.TblPagesBanners.Where(x => x.PageId == PageID).ToListAsync();
        //    var pagesDto = _mapper.Map<IEnumerable<GetPageBanner>>(pageBanners);

        //    return Ok(pagesDto);
        //}

    }
}