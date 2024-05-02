using System.Text.Json.Serialization;

namespace HwaidakAPI.DTOs.Responses.MeetingEvents
{
    public class GetMeetingEvent
    {
        public string HotelName { get; set; }
        public string HotelUrl { get; set; }

        [JsonIgnore]
        public int HotelId { get; set; }
        public string FacilityName { get; set; }

        public string FacilityPhotoHome { get; set; }

        public string FacilityPhoto { get; set; }

        public string FacilityUrl { get; set; }
        public string FacilitySummery { get; set; }

        public string MeetingSize { get; set; }

        public string MeetingLength { get; set; }

        public string MeetingWidths { get; set; }

        public string MeetingCellingHeight { get; set; }
        public string MeetingCapacity { get; set; }
        public string MeetingEventsType { get; set; }





    }
}
