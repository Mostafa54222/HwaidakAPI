using AutoMapper;
using HwaidakAPI.DTOs.Responses.SPA;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.SPA
{
    public class SPAProfile : Profile
    {
        public SPAProfile()
        {
            CreateMap<VwSpa, GetSPA>();
            CreateMap<VwSpa, GetSPADetails>();
            CreateMap<VwSpaService, GetSPAService>();
            CreateMap<TblSpaGallery, GetSPAGallery>();
        }
    }
}
