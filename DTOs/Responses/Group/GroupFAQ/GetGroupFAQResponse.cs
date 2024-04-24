namespace HwaidakAPI.DTOs.Responses.Group.GroupFAQ
{
    public class GetGroupFAQResponse
    {
        public MainResponse PageDetails { get; set; }
        public List<GetGroupFAQList> GroupFAQs { get; set; }
    }
}
