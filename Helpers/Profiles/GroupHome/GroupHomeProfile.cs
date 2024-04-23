using AutoMapper;
using HwaidakAPI.DTOs.Responses.Group;
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
            CreateMap<TblGroupLayout, GetGroupFooter>();

            CreateMap<TblGroupSocial, GetGroupSocials>();
        }
    }
}
