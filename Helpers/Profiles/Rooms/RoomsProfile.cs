using AutoMapper;
using HwaidakAPI.DTOs;
using HwaidakAPI.DTOs.Responses.Rooms;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Rooms
{
    public class RoomsProfile : Profile
    {
        public RoomsProfile()
        {

            CreateMap<Room, GetRoom>();

            CreateMap<RoomsContent, GetRoomContent>();
            CreateMap<RoomsGallery, GetRoomGallery>();
            CreateMap<VwRoomsGallery, GetRoomGallery>();
            CreateMap<VwRoomsAmenity, GetRoomAmenity>();

            CreateMap<Room, OtherRooms>();


            CreateMap<Room, GetRoomDetails>()
                .ForMember(dest => dest.RoomsGalleries, opt => opt.MapFrom(src => src.RoomsGalleries.ToList()));



            CreateMap<VwHotel, MainResponse>();
            CreateMap<VwRoom, GetRoom>();

            CreateMap<VwRoom, GetRoomDetails>();
        }
    }
}
