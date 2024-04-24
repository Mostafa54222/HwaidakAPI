using AutoMapper;
using HwaidakAPI.DTOs.Responses.Group;
using HwaidakAPI.DTOs.Responses.Group.GroupFAQ;
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
            CreateMap<TblGroupLayout, GetGroupHeader>();
            CreateMap<TblGroupLayout, GetGroupFooter>()
                .ForMember(dest => dest.Copyrights, opt => opt.MapFrom(src => src.GroupCopyrights));

            CreateMap<TblGroupSocial, GetGroupSocials>();

            CreateMap<VwGroupFaq, GetGroupFAQList>();
        }
    }
}
