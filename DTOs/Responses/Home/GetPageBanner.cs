namespace HwaidakAPI.DTOs.Responses.Home
{
    public class GetPageBanner
    {
        public int PageBannerId { get; set; }

        public string BannerFile { get; set; }

        public bool? BannerStatus { get; set; }

        public int? PageId { get; set; }
    }
}
