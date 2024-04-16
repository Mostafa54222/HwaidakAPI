using AutoMapper;
using HwaidakAPI.DTOs.Responses.Rooms;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Rooms
{
    public class RoomsProfile : Profile
    {
        public RoomsProfile()
        {
            CreateMap<Room, GetRoom>()
                .ForMember(dest => dest.RoomContents, opt => opt.MapFrom(src => src.RoomsContents.FirstOrDefault()))
                .ForMember(dest => dest.RoomsGalleries, opt => opt.MapFrom(src => src.RoomsGalleries.ToList()));

            CreateMap<RoomsContent, GetRoomContent>();
            CreateMap<RoomsGallery, GetRoomGallery>();
            CreateMap<VwRoomsAmenity, GetRoomAmenity>();

            CreateMap<Room, OtherRooms>();


            CreateMap<Room, GetRoomDetails>()
                .ForMember(dest => dest.RoomContents, opt => opt.MapFrom(src => src.RoomsContents.FirstOrDefault()))
                .ForMember(dest => dest.RoomsGalleries, opt => opt.MapFrom(src => src.RoomsGalleries.ToList()));
        }
    }
}
