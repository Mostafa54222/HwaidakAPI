namespace HwaidakAPI.DTOs.Responses.Restaurants
{
    public class GetRestaurantDetails
    {
        public int RestaurantId { get; set; }

        public string RestaurantNameSys { get; set; }

        public int? HotelId { get; set; }

        public int? RestaurantPosition { get; set; }

        public bool? RestaurantStatus { get; set; }

        public string RestaurantPhoto { get; set; }

        public string RestaurantBanner { get; set; }

        public string RestaurantUrl { get; set; }

        public int RestaurantContentId { get; set; }

        public int? LangId { get; set; }

        public string RestaurantName { get; set; }

        public string RestaurantSummery { get; set; }

        public string RestaurantDetails { get; set; }

        public bool? RestaurantStatusLang { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }

        public string HotelUrl { get; set; }

        public int? RestaurantCategoryId { get; set; }

        public bool? IsMoreDetails { get; set; }

        public int? RestaurantTypeId { get; set; }

        public string FilterBy { get; set; }

        public string RestaurantsTypeName { get; set; }

        public string Openinghours { get; set; }

        public string DressCode { get; set; }

        public string RestaurantsTypePhoto { get; set; }

        public string RestaurantsTypeIntro { get; set; }

        public string RestaurantCuisine { get; set; }

        public string RestaurantOpenFor { get; set; }

        public string RestaurantMenu { get; set; }

        public string RestaurantNote { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public string RestaurantPhotoHome { get; set; }

        public int? RestaurantPhotoWidth { get; set; }

        public int? RestaurantPhotoHomeWidth { get; set; }

        public int? RestaurantBannerWidth { get; set; }

        public int? RestaurantPhotoHieght { get; set; }

        public int? RestaurantPhotoHomeHieght { get; set; }

        public int? RestaurantBannerHieght { get; set; }

        public string HotelNameSys { get; set; }

        public DateTime? LastUpdate { get; set; }

        public string RestaurantBannerColorOverlayTo { get; set; }

        public string RestaurantBannerColorOverlayFrom { get; set; }

        public string RestaurantBannerTablet { get; set; }

        public int? RestaurantBannerWidthTablet { get; set; }

        public int? RestaurantBannerHieghtTablet { get; set; }

        public string RestaurantBannerTabletColorOverlayFrom { get; set; }

        public string RestaurantBannerTabletColorOverlayTo { get; set; }

        public string RestaurantBannerMobile { get; set; }

        public int? RestaurantBannerWidthMobile { get; set; }

        public int? RestaurantBannerHieghtMobile { get; set; }

        public string RestaurantBannerMobileColorOverlayFrom { get; set; }

        public string RestaurantBannerMobileColorOverlayTo { get; set; }

        public string Fb360url { get; set; }

        public int? RestaurantsTypePhotoWidth { get; set; }

        public int? RestaurantsTypePhotoHieght { get; set; }

        public int? RestaurantsTypeBannerWidth { get; set; }

        public int? RestaurantsTypeBannerHieght { get; set; }

        public string RestaurantsTypeBanner { get; set; }

        public string RestaurantsTypeBannerTablet { get; set; }

        public string RestaurantsTypeBannerMobile { get; set; }

        public int? RestaurantsTypeBannerTabletWidth { get; set; }

        public int? RestaurantsTypeBannerTabletHieght { get; set; }

        public int? RestaurantsTypeBannerMobileWidth { get; set; }

        public int? RestaurantsTypeBannerMobileHieght { get; set; }


        public List<GetRestaurantGallery> RestaurantGalleries { get; set; }
        public GetRestaurantType GetRestaurantType { get; set; }
    }
}
