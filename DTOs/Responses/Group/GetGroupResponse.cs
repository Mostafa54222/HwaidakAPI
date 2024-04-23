using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.DTOs.Responses.News;

namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupResponse
    {
        //public GetGroupHeader GroupHeader { get; set; }
        public List<GetGroupSlider> GroupSliders { get; set; } = [];
        public GetGroupHomeIntro GroupHomeIntro { get; set; }
        public List<GetGroupHomeIntroActivities> GroupHomeIntroActivities { get; set; } = [];
        public List<GetHotelList> Hotels { get; set; } = [];
        public GetGroupHome GroupHome { get; set; }
        public GetGroupHomeVideo GroupHomeVideo { get; set; }
        public List<GetNewsList> HotelNews { get; set; } = [];
        //public GetGroupFooter GroupFooter { get; set; }

    }
}
