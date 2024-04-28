using AutoMapper;
using HwaidakAPI.DTOs.Responses.Group;
using HwaidakAPI.DTOs.Responses.Group.GroupFAQ;
using HwaidakAPI.DTOs.Responses.Group.GroupNews;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.GroupHome
{
    public class GroupHomeProfile : Profile
    {
        public GroupHomeProfile()
        {
            CreateMap<VwGroupHome, GetGroupHome>();
            CreateMap<VwGroupHomeIntro, GetGroupHomeIntro>();
            CreateMap<VwGroupHomeIntroActivity, GetGroupHomeIntroActivities>();
            CreateMap<VwGroupHomeVideoSection, GetGroupHomeVideo>();

            CreateMap<TblGroupSlider, GetGroupSlider>();
            CreateMap<VwGroupHome, GetGroupContactUs>();
            CreateMap<TblGroupLayout, GetGroupHeader>();
            CreateMap<TblGroupLayout, GetGroupFooter>()
                .ForMember(dest => dest.Copyrights, opt => opt.MapFrom(src => src.GroupCopyrights));



            CreateMap<TblGroupSocial, GetGroupSocials>();
            CreateMap<VwHotel, GetGroupHotelList>();

            CreateMap<VwGroupFaq, GetGroupFAQList>();

            CreateMap<VwGroupNews, GetGroupNews>();

            CreateMap<VwHotel, GetHotelInfoForContactUs>();
        }
    }
}
