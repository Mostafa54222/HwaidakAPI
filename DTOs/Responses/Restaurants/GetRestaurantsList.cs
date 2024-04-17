namespace HwaidakAPI.DTOs.Responses.Restaurants
{
    public class GetRestaurantsList
    {
        public MainResponse PageDetails { get; set; }
        public List<GetRestaurant> RestauransList { get; set; }
    }
}
