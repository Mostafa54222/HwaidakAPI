using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.SPA;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class SPAController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public SPAController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        //[HttpGet("{languageCode}")]
        //public async Task<ActionResult<IEnumerable<GetSPA>>> GetSPA(string languageCode = "en")
        //{
        //    var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
        //    if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
        //    var spas = await _context.VwSpas.Where(x => x.LangId == language.LangId).ToListAsync();
        //    var spaDto = _mapper.Map<IEnumerable<GetSPA>>(spas);

        //    return Ok(spaDto);
        //}


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetSPA>>> GetHotelSPA(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var spas = await _context.VwSpas.Where(x => x.HotelId == hotel.HotelId && x.LangId == language.LangId && x.FacilityStatus == true).OrderBy(x => x.FacilityPosition).ToListAsync();

            var spaDto = _mapper.Map<IEnumerable<GetSPA>>(spas);


            return Ok(spaDto);
        }
        [HttpGet("GetSPA/{hotelUrl}/{SPAUrl}")]
        public async Task<ActionResult<IEnumerable<GetSPADetails>>> GetSPA(string hotelUrl,  string SPAUrl, string languageCode = "en")
        {

            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));

            var spa = await _context.VwSpas.Where(x => x.HotelId == hotel.HotelId && x.FacilityUrl == SPAUrl && x.LangId == language.LangId && x.FacilityStatus == true).FirstOrDefaultAsync();
            if (spa == null) return NotFound(new ApiResponse(404, "this SPA doesnt exist"));
            var spaDto = _mapper.Map<GetSPADetails>(spa);
            var spaGallery = await _context.TblSpaGalleries.Where(x => x.Spaid == spa.SpaId).ToListAsync();
            var spaServices = await _context.VwSpaServices.Where(x => x.SpaId == spa.SpaId && x.LangId == language.LangId).ToListAsync();


            spaDto.SPAGallery = spaGallery != null ? _mapper.Map<List<GetSPAGallery>>(spaGallery) : null;
            spaDto.SPAServices = spaServices != null ? _mapper.Map<List<GetSPAService>>(spaServices) : null;

            return Ok(spaDto);
        }

    }
}
