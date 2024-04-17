using HwaidakAPI.Models;

namespace HwaidakAPI.DTOs.Responses.Rooms
{
    public class GetRoomDetails
    {
        public string RoomName { get; set; }
        public string RoomPhoto { get; set; }

        public string RoomUrl { get; set; }
        
        public string RoomBanner { get; set; }
        public string RoomBannerTablet { get; set; }
        public string RoomBannerMobile { get; set; }
        public string RoomBannerAltTag { get; set; }
        public string RoomTypeCategoryName { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }

        public string RoomSummery { get; set; }

        public string RoomDetails { get; set; }

        public string MaxOccupancy { get; set; }

        public string RoomSize { get; set; }

        public string RoomBed { get; set; }

        public string RoomView { get; set; }
        public string HotelUrl { get; set; }






        public List<GetRoomGallery> RoomsGalleries { get; set; }
        public List<GetRoomAmenity> RoomAmenities { get; set; }
        public List<GetRoom> OtherRooms { get; set; }
    }
}
