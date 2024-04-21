using AutoMapper;
using HwaidakAPI.DTOs.Responses.ContactUs;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.ContactHotel
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<VwHotel, GetContactHotel>();
        }
    }
}
