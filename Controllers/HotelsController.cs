using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.Hotels;
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


            var hotelDto = _mapper.Map<GetHotel>(hotel);

            hotelDto.HotelGallery = hotelGallery != null ? _mapper.Map<List<GetHotelGallery>>(hotelGallery) : null;
            hotelDto.HotelFacilities = hotelfacilities != null ? _mapper.Map<List<GetHotelFacilities>>(hotelfacilities) : null;
            hotelDto.HotelRooms = hotelRooms != null ? _mapper.Map<List<GetRoom>>(hotelRooms) : null;

            return Ok(hotelDto);

        }

        [HttpGet("GetHotelFacilities/{languageCode}/{hotelurl}")]
        public async Task<ActionResult<IEnumerable<GetHotelFacilities>>> GetHotelFacilities(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelurl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var hotelFacilities = await _context.VwHotelsFacilities.Where(x => x.LangId == language.LangId && x.HotelId == hotel.HotelId).ToListAsync();
            var hotelFacilityDto = _mapper.Map<IEnumerable<GetHotelFacilities>>(hotelFacilities);
            return Ok(hotelFacilityDto);

        }

        [HttpGet("GetHotelFacilitiesGallery/{FacilityID}")]
        public async Task<ActionResult<IEnumerable<GetFacilitiyGallery>>> GetHotelFacilitiesGallery(int FacilityID)
        {
            var facility = await _context.Facilities.Where(x => x.FacilityId == FacilityID).FirstOrDefaultAsync();
            if (facility == null) return NotFound(new ApiResponse(404, "there is no facility with this name"));
            var hotelFacilitiesGallery = await _context.VwHotelsFacilitiesGalleries.Where(x => x.FacilitiesId == facility.FacilityId).ToListAsync();
            var hotelFacilityGalleryDto = _mapper.Map<IEnumerable<GetFacilitiyGallery>>(hotelFacilitiesGallery);
            return Ok(hotelFacilityGalleryDto);

        }

        [HttpGet("GetMasterHotelFacilities/{languageCode}/")]
        public async Task<ActionResult<IEnumerable<GetMasterHotelFacilities>>> GetMasterHotelFacilities(string languageCode = "en")
        {
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var MasterhotelFacilities = await _context.VwMasterHotelFacilities.Where(x => x.LangId == language.LangId).ToListAsync();
            var MasterhotelFacilityDto = _mapper.Map<IEnumerable<GetMasterHotelFacilities>>(MasterhotelFacilities);
            return Ok(MasterhotelFacilityDto);

        }
        [HttpGet("GetMasterHotelFacilitiesItems/{languageCode}/{HotelFacilitiesID}")]
        public async Task<ActionResult<IEnumerable<GetMasterHotelFacilities>>> GetMasterHotelFacilitiesItems(int HotelFacilitiesID, string languageCode = "en")
        {
            var facility = await _context.VwMasterHotelFacilities.Where(x => x.HotelFacilitiesId == HotelFacilitiesID).FirstOrDefaultAsync();
            if (facility == null) return NotFound(new ApiResponse(404, "this Facility Doesnt Exist"));
            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var MasterhotelFacilitiesItems = await _context.VwMasterHotelFacilitiesItems.Where(x => x.LangId == language.LangId && x.HotelFacilitiesId == facility.HotelFacilitiesId).ToListAsync();
            var MasterhotelFacilityItemsDto = _mapper.Map<IEnumerable<GitMasterHotelFacilitiesItems>>(MasterhotelFacilitiesItems);
            return Ok(MasterhotelFacilityItemsDto);

        }

    }
}
