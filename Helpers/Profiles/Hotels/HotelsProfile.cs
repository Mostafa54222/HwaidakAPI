using AutoMapper;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Hotels
{
    public class HotelsProfile : Profile
    {
        public HotelsProfile()
        {
            CreateMap<Hotel, GetHotel>();
            CreateMap<HotelsContent, GetHotelContent>();
            CreateMap<VwHotelsFacility, GetHotelFacilities>();
            CreateMap<VwHotelsFacilitiesGallery, GetFacilitiyGallery>();
            CreateMap<VwMasterHotelFacility, GetMasterHotelFacilities>();
            CreateMap<VwMasterHotelFacilitiesItem, GitMasterHotelFacilitiesItems>();

        }
    }
}
