using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class Restaurant
{
    public int RestaurantId { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreationDate { get; set; }

    public string RestaurantNameSys { get; set; }

    public int? RestaurantTypeId { get; set; }

    public int? HotelId { get; set; }

    public int? RestaurantPosition { get; set; }

    public bool? RestaurantStatus { get; set; }

    public string RestaurantPhoto { get; set; }

    public string RestaurantBanner { get; set; }

    public string RestaurantUrl { get; set; }

    public int? RestaurantCategoryId { get; set; }

    public bool? IsMoreDetails { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string RestaurantPhotoHome { get; set; }

    public int? RestaurantPhotoWidth { get; set; }

    public int? RestaurantPhotoHomeWidth { get; set; }

    public int? RestaurantBannerWidth { get; set; }

    public int? RestaurantPhotoHieght { get; set; }

    public int? RestaurantPhotoHomeHieght { get; set; }

    public int? RestaurantBannerHieght { get; set; }

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

    public virtual ICollection<RestaurantsContent> RestaurantsContents { get; set; } = new List<RestaurantsContent>();

    public virtual ICollection<RestaurantsGallery> RestaurantsGalleries { get; set; } = new List<RestaurantsGallery>();
}
