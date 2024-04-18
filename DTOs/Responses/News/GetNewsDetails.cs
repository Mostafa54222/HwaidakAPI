namespace HwaidakAPI.DTOs.Responses.News
{
    public class GetNewsDetails
    {

        public string NewsPhoto { get; set; }
        public DateTime? NewsDateTime { get; set; }
        public string NewsUrl { get; set; }
        public string NewsShortDescription { get; set; }
        public string NewsDetails { get; set; }
        public string NewsItemBanner { get; set; }
        public string NewsItemBannerTablet { get; set; }
        public string NewsItemBannerMobile { get; set; }
        public string HotelUrl { get; set; }

        public List<GetNewsGallery> NewsGallery { get; set; }
    }
}
