using HwaidakAPI.Models;

namespace HwaidakAPI.DTOs.Responses.Rooms
{
    public class GetRoomContent
    {
        public int RoomContentId { get; set; }

        public int? RoomId { get; set; }

        public int? LangId { get; set; }

        public string RoomName { get; set; }

        public string RoomSummery { get; set; }

        public string RoomDetails { get; set; }

        public string MaxOccupancy { get; set; }

        public string RoomSize { get; set; }

        public string RoomView { get; set; }

        public string RoomBed { get; set; }

        public bool? RoomStatusLang { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }

        public string StartingFromCodeLang { get; set; }

        public string RoomBannerAltTag { get; set; }

        public string RoomPhoto { get; set; }

        public string RoomPhotoHome { get; set; }
    }
}
