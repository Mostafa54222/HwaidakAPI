using AutoMapper;
using HwaidakAPI.DTOs;
using HwaidakAPI.DTOs.Responses.Restaurants;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Restaurant
{
    public class RestaurantsProfile : Profile
    {
        public RestaurantsProfile()
        {
            CreateMap<VwRestaurant, GetRestaurant>();
            CreateMap<VwRestaurant, GetRestaurantDetails>();
            CreateMap<VwRestaurantsGallery, GetRestaurantGallery>();
        }
    }
}
