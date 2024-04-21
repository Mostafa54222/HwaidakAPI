using HwaidakAPI.Models;

namespace HwaidakAPI.DTOs.Responses.Rooms
{
    public class GetRoom
    {

        public string RoomName { get; set; }
        public string RoomPhotoHome { get; set; }
        public string RoomUrl { get; set; }

        public string HotelUrl { get; set; }

        public string MaxOccupancy { get; set; }
        public string RoomSize { get; set; }

        public string RoomBed { get; set; }
        public string RoomTypeCategoryName { get; set; }


        public string RoomSummery { get; set; }

        public string RoomView { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }

    }
}
