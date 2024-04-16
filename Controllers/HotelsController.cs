using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.Hotels;
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
        public async Task<ActionResult<IEnumerable<GetHotel>>> GetHotels(string languageCode = "en")
        {
            var hotels = await _context.Hotels.ToListAsync();

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var hotelsContent = await _context.HotelsContents.Where(x => x.LangId == language.LangId).ToListAsync();
            if (hotelsContent == null) return NotFound(new ApiResponse(404, "there is no hotels with this language"));


            var hotelDtos = _mapper.Map<IEnumerable<GetHotel>>(hotels);
            foreach (var hotelDto in hotelDtos)
            {
                var content = hotelsContent.FirstOrDefault(x => x.HotelId == hotelDto.HotelId);
                hotelDto.HotelContent = content != null ? _mapper.Map<GetHotelContent>(content) : null;
            }

            return Ok(hotelDtos);
        }

        [HttpGet("{languageCode}/{hotelurl}")]
        public async Task<ActionResult<IEnumerable<GetHotel>>> GetHotels(string hotelurl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelurl).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

            var language = await _context.MasterLanguages.Where(x => x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (language == null) return NotFound(new ApiResponse(404, "this language doesnt exist"));
            var hotelContent = await _context.HotelsContents.Where(x => x.LangId == language.LangId && x.HotelId == hotel.HotelId).FirstOrDefaultAsync();

            var hotelDto = _mapper.Map<GetHotel>(hotel);
            hotelDto.HotelContent = hotelContent != null ? _mapper.Map<GetHotelContent>(hotelContent) : null;
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
            var hotelFacilitiesGallery = await _context.VwHotelsFacilitiesGalleries.Where(x=>x.FacilitiesId == facility.FacilityId).ToListAsync();
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
            var MasterhotelFacilitiesItems = await _context.VwMasterHotelFacilitiesItems.Where(x => x.LangId == language.LangId && x.HotelFacilitiesId==facility.HotelFacilitiesId).ToListAsync();
            var MasterhotelFacilityItemsDto = _mapper.Map<IEnumerable<GitMasterHotelFacilitiesItems>>(MasterhotelFacilitiesItems);
            return Ok(MasterhotelFacilityItemsDto);

        }

    }
}
