using HwaidakAPI.DTOs.Responses.Hotels;

namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupHotelList
    {
        public string GroupHomeHotelTitleTop { get; set; }
        public string GroupHomeHotelTitle { get; set; }
        public List<GetHotelList> Hotels { get; set; } = [];
    }
}
