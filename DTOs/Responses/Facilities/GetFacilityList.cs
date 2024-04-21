namespace HwaidakAPI.DTOs.Responses.Facilities
{
    public class GetFacilityList
    {
        public MainResponse PageDetails { get; set; }
        public List<GetFacility> Facilities { get; set; }

    }
}
