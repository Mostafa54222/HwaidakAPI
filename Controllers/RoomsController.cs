using AutoMapper;
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



        [HttpGet("{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetRoom>>> GetRooms(string languageCode = "en")
        {


            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var rooms = await _context.Rooms
                .Include(x => x.RoomsContents.Where(x => x.LangId == language.LangId))
                .Include(x => x.RoomsGalleries).ToListAsync();
            

            var roomDto = _mapper.Map<IEnumerable<GetRoom>>(rooms);
            foreach (var item in roomDto)
            {
                var roomam = await _context.VwRoomsAmenities.Where(x => x.RoomId == item.RoomId && x.LangId == language.LangId).ToListAsync();
                item.RoomAmenities = roomam != null ? _mapper.Map<List<GetRoomAmenity>>(roomam) : null;
            }

            return Ok(roomDto);
        }




        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetRoom>>> GetHotelRooms(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var rooms = await _context.Rooms.Where(x => x.HotelId == hotel.HotelId)
                .Include(x => x.RoomsContents.Where(x => x.LangId == language.LangId))
                .Include(x => x.RoomsGalleries).ToListAsync();

            var roomDto = _mapper.Map<IEnumerable<GetRoom>>(rooms);


            return Ok(roomDto);
        }

        [HttpGet("RoomDetails/{languageCode}/{hotelUrl}/{roomUrl}")]
        public async Task<ActionResult<GetRoomDetails>> GetRoomDetails(string hotelUrl, string roomUrl, string languageCode = "en")
        {

            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));


            var room = await _context.Rooms.Where(x => x.HotelId == hotel.HotelId && x.RoomUrl == roomUrl)
                .Include(x => x.RoomsContents.Where(x => x.LangId == language.LangId))
                .Include(x => x.RoomsGalleries).FirstOrDefaultAsync();




            var roomDto = _mapper.Map<GetRoomDetails>(room);

            var otherRooms = await _context.Rooms.Where(x => x.HotelId == hotel.HotelId && x.RoomUrl != roomUrl)
                .Include(x => x.RoomsContents.Where(x => x.LangId == language.LangId))
                .Include(x => x.RoomsGalleries).ToListAsync();

            var roomam = await _context.VwRoomsAmenities.Where(x => x.RoomId == roomDto.RoomId && x.LangId == language.LangId).ToListAsync();
            roomDto.RoomAmenities = roomam != null ? _mapper.Map<List<GetRoomAmenity>>(roomam) : null;


            roomDto.OtherRooms = otherRooms != null ? _mapper.Map<List<OtherRooms>>(otherRooms) : null;



            

            return Ok(roomDto);
        }



    }
}
