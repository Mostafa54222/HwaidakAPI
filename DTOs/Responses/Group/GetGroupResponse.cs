using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.DTOs.Responses.News;

namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupResponse
    {
        public List<GetGroupSlider> GroupSliders { get; set; } = [];
        public GetGroupHomeIntro GroupHomeIntro { get; set; }
        public GetGroupHotelListResponse Hotels { get; set; }
        public GetGroupSecondSection GroupHomeSecondSection { get; set; }
        public GetGroupHomeVideo GroupHomeVideo { get; set; }
        public GetGroupNewsList HotelNews { get; set; }

    }
}
