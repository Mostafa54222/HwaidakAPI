using AutoMapper;
using HwaidakAPI.DTOs.Responses.Home;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Home
{
    public class HomeProfile : Profile
    {
        public HomeProfile()
        {
            CreateMap<TblSlider, GetSliders>();

            CreateMap<TblSiteSocial, GetSiteSocials>();
            CreateMap<TblSiteContact, GetSiteContacts>();

            CreateMap<VwPage, GetPages>();
            CreateMap<TblPagesBanner, GetPageBanner>();
            CreateMap<VwHomeWhyU, GetHomeWhyUs>();
            CreateMap<VwHotel, GetHotelHome>();
        }
    }
}
