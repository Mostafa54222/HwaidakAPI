using HwaidakAPI.DTOs.Responses.Hotels;

namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupHotelListResponse
    {
        public string GroupHomeHotelTitleTop { get; set; }
        public string GroupHomeHotelTitle { get; set; }
        public List<GetGroupHotelList> Hotels { get; set; } = [];
    }
}
