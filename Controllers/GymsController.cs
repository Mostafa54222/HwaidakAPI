using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.DTOs.Responses.Rooms;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Controllers
{
    public class GymsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly IMapper _mapper;
        public GymsController(HwaidakHotelsWsdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<IEnumerable<GetGymList>>> GetHotelGyms(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == hotelUrl &&x.HotelStatus==true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));

           

            var Gyms = await _context.VwGyms.Where(x => x.HotelId == hotel.HotelId && x.LanguageAbbreviation == languageCode && x.FacilityStatus==true).ToListAsync();

            var gymDto = _mapper.Map<IEnumerable<GetGymList>>(Gyms);


            return Ok(gymDto);
        }
        [HttpGet("GetGym/{languageCode}/{HotelUrl}/{GymUrl}")]
        public async Task<ActionResult<IEnumerable<GetGym>>> GetGym(string HotelUrl, string GymUrl, string languageCode = "en")
        {
            var hotel = await _context.Hotels.Where(x => x.HotelUrl == HotelUrl && x.HotelStatus == true).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));


            var Gym = await _context.VwGyms.Where(x => x.FacilityUrl == GymUrl && x.HotelId == hotel.HotelId && x.FacilityStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (Gym == null) return NotFound(new ApiResponse(404, "this Gym doesnt exist"));
            var gymDto = _mapper.Map<GetGym>(Gym);
            var gymGallery = await _context.TblGymGalleries.Where(x => x.Gymid == Gym.GymId &&x.PhotoStatus==true).ToListAsync();
            //var gymServices = await _context.VwGymServices.Where(x => x.)

            gymDto.GymGallery = gymGallery != null ? _mapper.Map<List<GetGymGallery>>(gymGallery) : null;

            return Ok(gymDto);
        }

        [HttpGet("GetGymServices/{languageCode}")]
        public async Task<ActionResult<IEnumerable<GetGymService>>> GetGymServices(string languageCode = "en")
        {

            var gymservices = await _context.VwGymServices.Where(x => x.LanguageAbbreviation == languageCode && x.SpaservicesStatus==true).ToListAsync();
            var gymServiceDto = _mapper.Map<IEnumerable<GetGymService>>(gymservices);

            return Ok(gymServiceDto);
        }

    }
}
