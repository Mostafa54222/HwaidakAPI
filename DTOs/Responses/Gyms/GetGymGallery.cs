namespace HwaidakAPI.DTOs.Responses.Gyms
{
    public class GetGymGallery
    {
        public int FacilitiesFileId { get; set; }

        public int? Gymid { get; set; }

        public string PhotoFile { get; set; }

        public int? PhotoPosition { get; set; }

        public bool? PhotoStatus { get; set; }
    }
}
