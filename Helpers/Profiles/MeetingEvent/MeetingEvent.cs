using AutoMapper;
using HwaidakAPI.DTOs.Responses.MeetingEvents;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.MeetingEvent
{
    public class MeetingEvent: Profile
    {
        public MeetingEvent()
        {
            CreateMap<VwMeetingsEvent, GetMeetingEvent>();
            CreateMap<VwMeetingsEventsGallery, GetMeetingEventsGallery>();
        }
    }
}
