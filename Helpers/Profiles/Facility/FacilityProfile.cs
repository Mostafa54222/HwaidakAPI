using AutoMapper;
using HwaidakAPI.DTOs.Responses.Facilities;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Facility
{
    public class FacilityProfile : Profile
    {
        public FacilityProfile()
        {
            CreateMap<VwFacility, GetFacility>();
            CreateMap<FacilitiesGallery, GetFacilityGallery>();
            CreateMap<VwFacility, GetFacilityDetails>();
        }
    }
}
