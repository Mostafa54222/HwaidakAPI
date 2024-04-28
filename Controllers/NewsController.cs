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
        private readonly IConfiguration _configuration;

        public NewsController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }






        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetNewsList>>> GetHotelNews(string hotelUrl, string languageCode = "en")
        {


            var News = await _context.VwNews.Where(x => x.HotelUrl == hotelUrl && x.LanguageAbbreviation == languageCode && x.NewsStatus==true&&x.IsDeleted==false).ToListAsync();

            var NewsDto = _mapper.Map<IEnumerable<GetNewsList>>(News);

            foreach (var news in NewsDto)
            {
                news.NewsPhoto = _configuration["ImagesLink"] + news.NewsPhoto;
                news.NewsDateTime = DateTime.Parse(news.NewsDateTime.ToString()).ToString("dd MMMM yyyy");
            }

            return Ok(NewsDto);
        }

        [HttpGet("GetHotelNews/{languageCode}/{HotelUrl}/{NewsUrl}")]
        public async Task<ActionResult<GetNewsDetails>> GetHotelNews(string HotelUrl, string NewsUrl, string languageCode = "en")
        {
            var News = await _context.VwNews.Where(x => x.NewsUrl == NewsUrl && x.LanguageAbbreviation == languageCode && x.HotelUrl == HotelUrl && x.NewsStatus == true).FirstOrDefaultAsync();
            if (News == null) return NotFound(new ApiResponse(404, "this New doesnt exist"));
            var NewsGallery = await _context.TblNewsGalleries.Where(x => x.NewsId == News.NewsId &&x.PhotoStatus==true).ToListAsync();
            var NewsDto = _mapper.Map<GetNewsDetails>(News);

            NewsDto.NewsDateTime = DateTime.Parse(NewsDto.NewsDateTime.ToString()).ToString("dd MMMM yyyy");
            NewsDto.NewsPhoto = _configuration["ImagesLink"] + NewsDto.NewsPhoto;


            NewsDto.NewsGallery = NewsGallery != null ? _mapper.Map<List<GetNewsGallery>>(NewsGallery) : null;


            if (NewsDto.NewsGallery != null)
            {

                foreach (var newsgalleries in NewsDto.NewsGallery)
                {
                    newsgalleries.PhotoFile = _configuration["ImagesLink"] + newsgalleries.PhotoFile;
                }
            }

            return Ok(NewsDto);
        }
    }
}
