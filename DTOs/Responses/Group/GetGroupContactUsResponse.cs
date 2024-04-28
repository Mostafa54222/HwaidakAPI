using HwaidakAPI.DTOs.Responses.Group.GroupFAQ;

namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupContactUsResponse
    {
        public MainResponse PageDetails { get; set; }
        public List<GetHotelInfoForContactUs> HotelsContact { get; set; }
    }
}
