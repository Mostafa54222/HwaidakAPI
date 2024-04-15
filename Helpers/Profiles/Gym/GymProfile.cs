using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gyms;
using HwaidakAPI.DTOs.Responses.Hotels;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Gym
{
    public class GymProfile: Profile
    {
        public GymProfile()
        {
            CreateMap<VwGym, GetGym>();
            CreateMap<VwGymService, GetGymService>();
        }
    }
}
