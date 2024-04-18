using HwaidakAPI.DTOs.Responses.News;
using HwaidakAPI.DTOs.Responses.Rooms;

namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetHotel
    {
        public string HotelName { get; set; }
        public string HotelSummery { get; set; }

        public string HotelOverview { get; set; }

        public string HotelUrl { get; set; }

        public string HotelPhoto { get; set; }

        public string HotelLogo { get; set; }

        public string HotelEmail { get; set; }
        public string HotelAccommodation { get; set; }

        public string HotelDining { get; set; }

        public string HotelMeeting { get; set; }


        public string HotelAddress { get; set; }

        public string HotelGoogleMap { get; set; }

        public string HotelNear { get; set; }

        public string HotelNearTitle { get; set; }


        public List<GetHotelGallery> HotelGallery { get; set; } = [];
        public List<GetRoom> HotelRooms { get; set; } = [];
        public List<GetHotelFacilities> HotelFacilities { get; set; } = [];
        public List<GetNewsList> HotelNews { get; set; } = [];

    }
}
