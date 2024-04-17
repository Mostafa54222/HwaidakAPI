namespace HwaidakAPI.DTOs.Responses.MeetingEvents
{
    public class GetMeetingEventWithPageDetails
    {
        public string HotelMeeting { get; set; }
        public string HotelMeetingTitle { get; set; }
        public string HotelMeetingMetatagTitle { get; set; }
        public string HotelMeetingMetatagDescription { get; set; }
        public string HotelMeetingBanner { get; set; }
        public string HotelMeetingBannerTablet { get; set; }
        public string HotelMeetingBannerMobile { get; set; }
        public string HotelMeetingThanksBannerTablet { get; set; }
        public string HotelMeetingThanksBannerMobile { get; set; }
        public List<GetMeetingEvent> MeetingEvent { get; set; }
    }
}
