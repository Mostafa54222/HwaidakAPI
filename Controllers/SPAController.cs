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


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetSPA>>> GetHotelSPA(string hotelUrl, string languageCode = "en")
        {

            var spas = await _context.VwSpas.Where(x => x.HotelUrl == hotelUrl && x.LanguageAbbreviation == languageCode && x.FacilityStatus == true && x.IsDeleted == false).OrderBy(x => x.FacilityPosition).OrderBy(x => x.FacilityPosition).ToListAsync();

            var spaDto = _mapper.Map<IEnumerable<GetSPA>>(spas);


            return Ok(spaDto);
        }
        [HttpGet("GetSPA/{hotelUrl}/{SPAUrl}")]
        public async Task<ActionResult<IEnumerable<GetSPADetails>>> GetSPA(string hotelUrl,  string SPAUrl, string languageCode = "en")
        {
            var spa = await _context.VwSpas.Where(x => x.HotelUrl == hotelUrl && x.IsDeleted==false && x.FacilityUrl == SPAUrl && x.LanguageAbbreviation == languageCode && x.FacilityStatus == true).FirstOrDefaultAsync();
            if (spa == null) return NotFound(new ApiResponse(404, "this SPA doesnt exist"));
            var spaDto = _mapper.Map<GetSPADetails>(spa);
            var spaGallery = await _context.TblSpaGalleries.Where(x => x.Spaid == spa.SpaId &&x.PhotoStatus==true).OrderBy(x => x.PhotoPosition).ToListAsync();
            var spaServices = await _context.VwSpaServices.Where(x => x.LanguageAbbreviation == languageCode && x.SpaId == spa.SpaId &&x.SpaservicesStatus==true && x.LanguageAbbreviation == languageCode).OrderBy(x => x.SpaservicesPosition).ToListAsync();


            spaDto.SPAGallery = spaGallery != null ? _mapper.Map<List<GetSPAGallery>>(spaGallery) : null;
            spaDto.SPAServices = spaServices != null ? _mapper.Map<List<GetSPAService>>(spaServices) : null;

            return Ok(spaDto);
        }

    }
}
