using AutoMapper;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Restaurant
{
    public class RestaurantsProfile : Profile
    {
        public RestaurantsProfile()
        {
            CreateMap<VwRestaurant, GetRestaurant>();
        }
    }
}
