using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.News;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class NewsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public NewsController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }




        [HttpGet("{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetNews>>> GetNews(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var News = await _context.VwNews.Where(x => x.LangId == language.LangId).ToListAsync();
            var NewsDto = _mapper.Map<IEnumerable<GetNews>>(News);
            return Ok(NewsDto);
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetNews>>> GetHotelNews(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var News = await _context.VwNews.Where(x => x.HotelId == hotel.HotelId).ToListAsync();

            var NewsDto = _mapper.Map<IEnumerable<GetNews>>(News);


            return Ok(NewsDto);
        }

        [HttpGet("GetHotelNewsGallery/{languageCode}/{NewsID}")]
        public async Task<ActionResult<IEnumerable<GetNewsGallery>>> GetHotelNewsGallery(int NewsID, string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var News = await _context.TblNews.Where(x => x.NewsId == NewsID).FirstOrDefaultAsync();
            if (News == null) return NotFound(new ApiResponse(404, "this New doesnt exist"));
            var NewsGallery = await _context.TblNewsGalleries.Where(x => x.NewsId == NewsID).ToListAsync();
            var NewsGalleryDto = _mapper.Map<IEnumerable<GetNewsGallery>>(NewsGallery);

            return Ok(NewsGalleryDto);
        }
    }
}
