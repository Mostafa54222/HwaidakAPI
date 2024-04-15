namespace HwaidakAPI.DTOs.Responses.News
{
    public class GetNewsGallery
    {
        public int NewsId { get; set; }

        public string NewsTitleSys { get; set; }

        public string NewsPhoto { get; set; }

        public bool? NewsStatus { get; set; }

        public DateTime? NewsDateTime { get; set; }

        public string NewsUrl { get; set; }

        public string NewsShortDescription { get; set; }

        public string NewsDetails { get; set; }

        public int? LangId { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }

        public bool? LangStatus { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? ItemPhotoWidth { get; set; }

        public int? ItemPhotoHieght { get; set; }

        public int? HotelId { get; set; }

        public string NewsItemBanner { get; set; }

        public int? NewsItemBannerPhotoHieght { get; set; }

        public int? NewsItemBannerPhotoWidth { get; set; }

        public string NewsItemBannerTablet { get; set; }

        public int? NewsItemBannerTabletHieght { get; set; }

        public int? NewsItemBannerTabletWidth { get; set; }

        public string NewsItemBannerMobile { get; set; }

        public int? NewsItemBannerMobileWidth { get; set; }

        public int? NewsItemBannerMobileHieght { get; set; }

        public string HotelNameSys { get; set; }

        public string HotelUrl { get; set; }
    }
}
