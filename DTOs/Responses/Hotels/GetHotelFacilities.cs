
using HwaidakAPI.DTOs.Responses.Facilities;

namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetHotelFacilities
    {
        public string SectionActivitiesTitle { get; set; }
        public string SectionActivitiesText { get; set; }

        public List<GetFacility> Facilities { get; set; }
    }
}
