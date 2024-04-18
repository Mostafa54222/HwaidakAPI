﻿using AutoMapper;
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
            var hotels = await _context.VwHotels.ToListAsync();

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var hotelDtos = _mapper.Map<List<GetHotelList>>(hotels);


            return Ok(hotelDtos);
        }

        [HttpGet("{languageCode}/{hotelurl}")]
        public async Task<ActionResult<GetHotel>> GetHotel(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelurl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode && x.LangStatus == true).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));



            var hotelGallery = await _context.VwGalleries.Where(x => x.LangId == language.LangId && x.HotelId == hotel.HotelId && x.GalleryStatus == true).OrderBy(x => x.GalleryPosition).ToListAsync();
            var hotelfacilities = await _context.VwHotelsFacilities.Where(x => x.HotelId == hotel.HotelId && x.HotelFacilitiesItemStatus == true).OrderBy(x => x.HotelFacilitiesItemPosition).ToListAsync();
            var hotelRooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.RoomStatus == true).OrderBy(x => x.RoomPosition).ToListAsync();
            var hotelNews = await _context.VwNews.Where(x => x.HotelId == hotel.HotelId && x.NewsStatus == true).ToListAsync();

            var hotelDto = _mapper.Map<GetHotel>(hotel);

            hotelDto.HotelGallery = hotelGallery != null ? _mapper.Map<List<GetHotelGallery>>(hotelGallery) : null;
            hotelDto.HotelFacilities = hotelfacilities != null ? _mapper.Map<List<GetHotelFacilities>>(hotelfacilities) : null;
            hotelDto.HotelRooms = hotelRooms != null ? _mapper.Map<List<GetRoom>>(hotelRooms) : null;
            hotelDto.HotelNews = hotelNews != null ? _mapper.Map<List<GetNewsList>>(hotelNews) : null;

            return Ok(hotelDto);

        }

        //[HttpGet("GetHotelFacilitiesGallery/{FacilityID}")]
        //public async Task<ActionResult<IEnumerable<GetFacilitiyGallery>>> GetHotelFacilitiesGallery(int FacilityID)
        //{
        //    var facility = await _context.Facilities.Where(x => x.FacilityId == FacilityID).FirstOrDefaultAsync();
        //    if (facility == null) return NotFound(new ApiResponse(404, "there is no facility with this ID"));
        //    var hotelFacilitiesGallery = await _context.VwHotelsFacilitiesGalleries.Where(x => x.FacilitiesId == facility.FacilityId).ToListAsync();
        //    var hotelFacilityGalleryDto = _mapper.Map<IEnumerable<GetFacilitiyGallery>>(hotelFacilitiesGallery);
        //    return Ok(hotelFacilityGalleryDto);

        //}

    }
}
