using HwaidakAPI.DTOs.Responses.Home;
using HwaidakAPI.DTOs.Responses.News;
using HwaidakAPI.DTOs.Responses.Rooms;

namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetHotel
    {
        public string HotelName { get; set; }

        public string SectionWelcomeTitle1 { get; set; }

        public string SectionWelcomeTitle2 { get; set; }

        public string SectionWelcomeTitleText { get; set; }
        
        public string HotelUrl { get; set; }

        public string HotelPhoto { get; set; }

        public string HotelLogo { get; set; }

        public string HotelNear { get; set; }

        public string HotelNearTitle { get; set; }

        public List<GetSliders> Sliders { get; set; }

        //public List<GetHotelGallery> HotelGallery { get; set; } = [];
        public List<GetHotelNearBy> HotelNearBy { get; set; }
        public List<GetRoom> HotelRooms { get; set; } = [];
        public List<GetHotelFacilities> HotelFacilities { get; set; } = [];
        public List<GetNewsList> HotelNews { get; set; } = [];

    }
}
