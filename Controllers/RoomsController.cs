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
        private readonly IConfiguration _configuration;

        public RoomsController(HwaidakHotelsWsdbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }



        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<GetRoomsList>> GetHotelRooms(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var rooms = await _context.VwRooms.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.RoomStatus == true &&x.IsDeleted==false).ToListAsync();

            var roomDto = _mapper.Map<List<GetRoom>>(rooms);

            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelAccommodationTitle,
                PageBannerPC = _configuration["ImagesLink"] + hotel.HotelAccommodationBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelAccommodationBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelAccommodationBannerTablet,
                PageText = hotel.HotelAccommodation,
                PageMetatagTitle = hotel.HotelAccommodationMetatagTitle,
                PageMetatagDescription = hotel.HotelAccommodationMetatagDescription
            };

            foreach (var room in roomDto)
            {
                room.RoomPhotoHome = _configuration["ImagesLink"] + room.RoomPhotoHome;
            }


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


            var roomdetails = await _context.VwRooms.Where(x => x.HotelUrl == hotelUrl && x.RoomUrl == roomUrl &&  x.LanguageAbbreviation == languageCode && x.RoomStatus == true &&x.IsDeleted==false).FirstOrDefaultAsync();
            var roomam = await _context.VwRoomsAmenities.Where(x => x.RoomId == roomdetails.RoomId && x.LanguageAbbreviation == languageCode && x.RoomAmenitiesStatus == true).ToListAsync();
            var roomgallery = await _context.VwRoomsGalleries.Where(x => x.RoomId == roomdetails.RoomId && x.PhotoStatus == true).ToListAsync();
            var otherrooms = await _context.VwRooms.Where(x => x.HotelUrl == hotelUrl && x.LanguageAbbreviation == languageCode && x.RoomUrl != roomUrl && x.RoomStatus == true && x.IsDeleted == false).ToListAsync();
            var roomDto = _mapper.Map<GetRoomDetails>(roomdetails);

            roomDto.RoomPhoto = _configuration["ImagesLink"] + roomDto.RoomPhoto;
            roomDto.RoomBanner = _configuration["ImagesLink"] + roomDto.RoomBanner;
            roomDto.RoomBannerMobile = _configuration["ImagesLink"] + roomDto.RoomBannerMobile;
            roomDto.RoomBannerTablet = _configuration["ImagesLink"] + roomDto.RoomBannerTablet;

            roomDto.RoomAmenities = roomam != null ? _mapper.Map<List<GetRoomAmenity>>(roomam) : null;
            roomDto.OtherRooms = otherrooms != null ? _mapper.Map<List<GetRoom>>(otherrooms) : null;
            roomDto.RoomsGalleries = roomgallery != null ? _mapper.Map<List<GetRoomGallery>>(roomgallery) : null;


            if (roomDto.OtherRooms != null)
            {
                foreach (var otherr in roomDto.OtherRooms)
                {
                    otherr.RoomPhotoHome = _configuration["ImagesLink"] + otherr.RoomPhotoHome;
                }
            }
            if(roomDto.RoomAmenities != null)
            {
                foreach (var roomaminities in roomDto.RoomAmenities)
                {
                    roomaminities.RoomAmenitiesPhoto = _configuration["IconsLink"] + roomaminities.RoomAmenitiesPhoto;
                }
            }
            if (roomDto.RoomsGalleries != null)
            {

                foreach (var roomgalleries in roomDto.RoomsGalleries)
                {
                    roomgalleries.PhotoFile = _configuration["ImagesLink"] + roomgalleries.PhotoFile;
                }
            }



            return Ok(roomDto);
        }



    }
}
