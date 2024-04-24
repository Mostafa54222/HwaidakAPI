using HwaidakAPI.DTOs.Responses.News;

namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupNewsList
    {
        public string GroupHomeNewsTitleTop { get; set; }
        public string GroupHomeNewsTitle { get; set; }
        public List<GetNewsList> NewsList { get; set; } = [];
    }
}
