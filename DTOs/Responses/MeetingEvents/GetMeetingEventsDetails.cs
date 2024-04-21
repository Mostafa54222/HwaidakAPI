namespace HwaidakAPI.DTOs.Responses.MeetingEvents
{
    public class GetMeetingEventsDetails
    {
        public string HotelName { get; set; }
        public string FacilityPhoto { get; set; }
        public string FacilityBanner { get; set; }
        public string FacilityBannerMobile { get; set; }
        public string FacilityBannerTablet { get; set; }

        public string FacilityUrl { get; set; }
        public string FacilityName { get; set; }

        public string FacilitySummery { get; set; }

        public string FacilityDetails { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }


        public string MeetingSize { get; set; }

        public string MeetingLength { get; set; }

        public string MeetingWidths { get; set; }

        public string MeetingCellingHeight { get; set; }

        public string MeetingCapacity { get; set; }

        //public string FacilityPhotoHome { get; set; }

        public List<GetMeetingEventsGallery> MeetingEventGallery { get; set; }

        public List<GetMeetingEvent> OtherMeetingEvents { get; set; }



    }
}
