using AutoMapper;
using HwaidakAPI.DTOs.Responses.Home;
using HwaidakAPI.DTOs.Responses.Hotels;
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

        [HttpGet("GetWhyUs/{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetHomeWhyUs>>> GetWhyUs(string languageCode = "en")
        {

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            

            var WhyUs= await _context.VwHomeWhyUs.Where(x=>x.LangId==language.LangId).ToListAsync();
            var whyUsDto = _mapper.Map<IEnumerable<GetHomeWhyUs>>(WhyUs);
            

            return Ok(whyUsDto);
        }

        [HttpGet("GetWhyUsByHotel/{languageCode}/{HotelId}")]
        public async Task<ActionResult<IEnumerable<GetHomeWhyUs>>> GetWhyUsByHotel(int HotelId, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelId == HotelId).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "this hotel doesnt exist"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var WhyUs = await _context.VwHomeWhyUs.Where(x => x.LangId == language.LangId && x.HotelId==hotel.HotelId).ToListAsync();
            var whyUsDto = _mapper.Map<IEnumerable<GetHomeWhyUs>>(WhyUs);


            return Ok(whyUsDto);
        }

    }
}