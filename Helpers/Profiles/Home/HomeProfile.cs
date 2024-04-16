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
        }
    }
}
