using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.Hotels;
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






        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetNewsList>>> GetHotelNews(string hotelUrl, string languageCode = "en")
        {


            var News = await _context.VwNews.Where(x => x.HotelUrl == hotelUrl && x.LanguageAbbreviation == languageCode && x.NewsStatus==true&&x.IsDeleted==false).ToListAsync();

            var NewsDto = _mapper.Map<IEnumerable<GetNewsList>>(News);


            return Ok(NewsDto);
        }

        [HttpGet("GetHotelNews/{languageCode}/{HotelUrl}/{NewsUrl}")]
        public async Task<ActionResult<GetNewsDetails>> GetHotelNews(string HotelUrl, string NewsUrl, string languageCode = "en")
        {
            var News = await _context.VwNews.Where(x => x.NewsUrl == NewsUrl && x.LanguageAbbreviation == languageCode && x.HotelUrl == HotelUrl && x.NewsStatus == true).FirstOrDefaultAsync();
            if (News == null) return NotFound(new ApiResponse(404, "this New doesnt exist"));
            var NewsGallery = await _context.TblNewsGalleries.Where(x => x.NewsId == News.NewsId &&x.PhotoStatus==true).ToListAsync();
            var NewsDto = _mapper.Map<GetNewsDetails>(News);
            
            NewsDto.NewsGallery = NewsGallery != null ? _mapper.Map<List<GetNewsGallery>>(NewsGallery) : null;

            return Ok(NewsDto);
        }
    }
}
