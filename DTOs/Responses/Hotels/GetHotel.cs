using HwaidakAPI.DTOs.Responses.ContactUs;
using HwaidakAPI.DTOs.Responses.Facilities;
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


        public string SectionRoomTitleBack { get; set; }
        public string SectionRoomTitle { get; set; }
        public string SectionRoomText { get; set; }

        public string SectionActivitiesTitle { get; set; }
        public string SectionActivitiesText { get; set; }




        public string SectionNewsTitle { get; set; }
        public string SectionNewsText { get; set; }


        public string HotelUrl { get; set; }

        public string HotelPhoto { get; set; }


        public string HotelNear { get; set; }

        public string HotelNearTitle { get; set; }


        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }


        public List<GetSliders> Sliders { get; set; }
        public List<GetHotelPartners> HotelPartners { get; set; }

        public List<GetHotelNearBy> HotelNearBy { get; set; }
        public List<GetRoom> HotelRooms { get; set; } = [];
        public List<GetFacility> HotelFacilities { get; set; } = [];
        public List<GetNewsList> HotelNews { get; set; } = [];
        //public GetHotelFooter HotelFooter { get; set; }

    }
}
