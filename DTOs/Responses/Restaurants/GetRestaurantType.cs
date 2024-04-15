namespace HwaidakAPI.DTOs.Responses.Restaurants
{
    public class GetRestaurantType
    {
        public int RestaurantsTypeId { get; set; }

        public string FilterBy { get; set; }

        public string RestaurantsTypePhoto { get; set; }

        public int RestaurantsTypeLangId { get; set; }

        public int? LangId { get; set; }

        public string RestaurantsTypeName { get; set; }

        public string RestaurantsTypeIntro { get; set; }

        public string LanguageName { get; set; }

        public string LanguageAbbreviation { get; set; }

        public string LanguageFlag { get; set; }

        public bool? LangStatus { get; set; }

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
    }
}
