using AutoMapper;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Hotels
{
    public class HotelsProfile : Profile
    {
        public HotelsProfile()
        {
            CreateMap<VwHotelsFacility, GetHotelFacilities>();
            CreateMap<VwGallery, GetHotelGallery>();
            CreateMap<HotelsContent, GetHotelContent>();
            CreateMap<VwHotelsFacilitiesGallery, GetFacilitiyGallery>();
            CreateMap<VwMasterHotelFacility, GetMasterHotelFacilities>();
            CreateMap<VwMasterHotelFacilitiesItem, GitMasterHotelFacilitiesItems>();




            CreateMap<VwHotel, GetHotel>()
                .ForMember(dest => dest.HotelGallery, opt => opt.Ignore())
                .ForMember(dest => dest.HotelFacilities, opt => opt.Ignore());

            CreateMap<VwHotel, GetHotelList>();

        }
    }
}
