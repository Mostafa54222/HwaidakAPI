using AutoMapper;
using HwaidakAPI.DTOs.Responses.Home;
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

        [HttpGet("GetSliders/{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetSliders>>> GetSliders(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var sliders = await _context.TblSliders.Where(x => x.LangId == language.LangId).ToListAsync();
            var slidersDto = _mapper.Map<IEnumerable<GetSliders>>(sliders);

            return Ok(slidersDto);
        }

        [HttpGet("GetSiteContacts/{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetSiteContacts>>> GetSiteContacts(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var siteContacts = await _context.TblSiteContacts.Where(x => x.LangId == language.LangId).ToListAsync();
            var siteContactsDto = _mapper.Map<IEnumerable<GetSiteContacts>>(siteContacts);

            return Ok(siteContactsDto);
        }

        [HttpGet("GetSiteSocials")]
        public async Task<ActionResult<IEnumerable<GetSiteSocials>>> GetSiteSocials()
        {
            var siteSocails = await _context.TblSiteSocials.ToListAsync();
            var siteSocailsDto = _mapper.Map<IEnumerable<GetSiteSocials>>(siteSocails);

            return Ok(siteSocailsDto);
        }
    }
}