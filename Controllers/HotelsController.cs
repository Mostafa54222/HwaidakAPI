using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
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

        public HotelsController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{languageCode}")]
        public async Task<ActionResult<List<GetHotelList>>> GetHotels(string languageCode = "en")
        {

            var hotels = await _context.VwHotels.Where(x=>x.HotelStatus == true && x.LanguageAbbreviation == languageCode).ToListAsync();

            var hotelDtos = _mapper.Map<List<GetHotelList>>(hotels);


            return Ok(hotelDtos);
        }

        [HttpGet("{languageCode}/{hotelurl}")]
        public async Task<ActionResult<GetHotel>> GetHotel(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelurl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));



            var hotelGallery = await _context.VwGalleries.Where(x => x.LanguageAbbreviation == languageCode && x.HotelId == hotel.HotelId && x.GalleryStatus == true).OrderBy(x => x.GalleryPosition).ToListAsync();
            var hotelfacilities = await _context.VwHotelsFacilities.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.HotelFacilitiesItemStatus == true).OrderBy(x => x.HotelFacilitiesItemPosition).ToListAsync();
            var hotelRooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.RoomStatus == true).OrderBy(x => x.RoomPosition).ToListAsync();
            var hotelNews = await _context.VwNews.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.NewsStatus == true).ToListAsync();

            var hotelDto = _mapper.Map<GetHotel>(hotel);

            hotelDto.HotelGallery = hotelGallery != null ? _mapper.Map<List<GetHotelGallery>>(hotelGallery) : null;
            hotelDto.HotelFacilities = hotelfacilities != null ? _mapper.Map<List<GetHotelFacilities>>(hotelfacilities) : null;
            hotelDto.HotelRooms = hotelRooms != null ? _mapper.Map<List<GetRoom>>(hotelRooms) : null;
            hotelDto.HotelNews = hotelNews != null ? _mapper.Map<List<GetNewsList>>(hotelNews) : null;

            return Ok(hotelDto);

        }

    }
}
