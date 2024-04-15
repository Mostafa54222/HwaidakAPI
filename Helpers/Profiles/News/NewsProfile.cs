using AutoMapper;
using HwaidakAPI.DTOs.Responses.News;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.News
{
    public class NewsProfile: Profile
    {
        public NewsProfile()
        {
            CreateMap<VwNews, GetNews>();
            CreateMap<TblNewsGallery,GetNewsGallery>();
        }
    }
}
