using AutoMapper;
using HwaidakAPI.DTOs.Responses.MeetingEvents;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.MeetingEvent
{
    public class MeetingEvent: Profile
    {
        public MeetingEvent()
        {
            CreateMap<VwMeetingsEvent, GetMeetingEvent>()
                .ForMember(dest => dest.HotelName, opt => opt.MapFrom(src => src.HotelNameSys));
            CreateMap<VwMeetingsEvent, GetMeetingEventsDetails>()
                .ForMember(dest => dest.HotelName, opt => opt.MapFrom(src => src.HotelNameSys));
            CreateMap<VwMeetingsEventsGallery, GetMeetingEventsGallery>();
            CreateMap<VwHotel, GetMeetingEventWithPageDetails>();
        }
    }
}
