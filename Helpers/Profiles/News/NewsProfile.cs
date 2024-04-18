using AutoMapper;
using HwaidakAPI.DTOs.Responses.News;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.News
{
    public class NewsProfile: Profile
    {
        public NewsProfile()
        {
            CreateMap<VwNews, GetNewsDetails>();
            CreateMap<VwNews, GetNewsList>();
            CreateMap<TblNewsGallery,GetNewsGallery>();
        }
    }
}
