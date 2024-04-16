namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetFacilitiyGallery
    {
        public int FacilitiesFileId { get; set; }

        public int? FacilitiesId { get; set; }

        public string PhotoFile { get; set; }

        public int? PhotoPosition { get; set; }

        public bool? PhotoStatus { get; set; }

        public int? HotelId { get; set; }

        public int? PhotoWidth { get; set; }

        public int? PhotoHieght { get; set; }
    }
}
