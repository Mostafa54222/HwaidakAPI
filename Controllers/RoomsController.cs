using AutoMapper;
using HwaidakAPI.DTOs;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.DTOs.Responses.Rooms;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class RoomsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public RoomsController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetRoomsList>> GetHotelRooms(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var rooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.RoomStatus == true).ToListAsync();

            var roomDto = _mapper.Map<List<GetRoom>>(rooms);

            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelAccommodationTitle,
                PageBannerPC = hotel.HotelAccommodationBanner,
                PageBannerMobile = hotel.HotelAccommodationBannerMobile,
                PageBannerTablet = hotel.HotelAccommodationBannerTablet,
                PageText = hotel.HotelAccommodation,
                PageMetatagTitle = hotel.HotelAccommodationMetatagTitle,
                PageMetatagDescription = hotel.HotelAccommodationMetatagDescription
            };
            GetRoomsList model = new GetRoomsList
            {
                PageDetails = pagedetails,
                RoomsList = roomDto
            };
            


            return Ok(model);
        }

        [HttpGet("RoomDetails/{languageCode}/{hotelUrl}/{roomUrl}")]
        public async Task<ActionResult<GetRoomDetails>> GetRoomDetails(string hotelUrl, string roomUrl, string languageCode = "en")
        {

            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var roomdetails = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.RoomUrl != roomUrl &&  x.LangId == language.LangId && x.RoomStatus == true).FirstOrDefaultAsync();
            var roomam = await _context.VwRoomsAmenities.Where(x => x.RoomId == roomdetails.RoomId && x.LangId == language.LangId && x.RoomAmenitiesStatus == true).ToListAsync();
            var roomgallery = await _context.VwRoomsGalleries.Where(x => x.RoomId == roomdetails.RoomId && x.PhotoStatus == true).ToListAsync();
            var otherrooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.RoomUrl != roomUrl && x.RoomStatus == true).ToListAsync();
            var roomDto = _mapper.Map<GetRoomDetails>(roomdetails);


            roomDto.RoomAmenities = roomam != null ? _mapper.Map<List<GetRoomAmenity>>(roomam) : null;
            roomDto.OtherRooms = otherrooms != null ? _mapper.Map<List<GetRoom>>(otherrooms) : null;



            return Ok(roomDto);
        }



    }
}
