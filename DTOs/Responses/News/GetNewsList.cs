namespace HwaidakAPI.DTOs.Responses.News
{
    public class GetNewsList
    {
        public string NewsPhoto { get; set; }
        public DateTime? NewsDateTime { get; set; }
        public string NewsUrl { get; set; }
        public string NewsShortDescription { get; set; }
        public string HotelUrl { get; set; }
    }
}
