namespace HwaidakAPI.DTOs.Responses.Rooms
{
    public class GetRoomGallery
    {
        public int RoomFileId { get; set; }

        public int? RoomId { get; set; }

        public string PhotoFile { get; set; }

        public int? PhotoPosition { get; set; }

        public bool? PhotoStatus { get; set; }

        public int? PhotoTypeId { get; set; }

        public int? PhotoWidth { get; set; }

        public int? PhotoHieght { get; set; }

        public double? PhotoSize { get; set; }

        public string PhotoFormat { get; set; }

        public double? PhotoRatio { get; set; }
    }
}
