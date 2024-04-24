using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwFacility
{
    public int FacilityId { get; set; }

    public int? HotelId { get; set; }

    public string FacilityNameSys { get; set; }

    public string FacilityPhoto { get; set; }

    public string FacilityBanner { get; set; }

    public bool? FacilityStatus { get; set; }

    public int? FacilityPosition { get; set; }

    public string FacilityUrl { get; set; }

    public int FacilityContentId { get; set; }

    public int? LangId { get; set; }

    public bool? FacilityStatusLang { get; set; }

    public string FacilityName { get; set; }

    public string FacilitySummery { get; set; }

    public string FacilityDetails { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? IsMoreDetails { get; set; }

    public string HotelUrl { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string FacilityPhotoHome { get; set; }

    public int? FacilityPhotoWidth { get; set; }

    public int? FacilityPhotoHieght { get; set; }

    public int? FacilityPhotoHomeWidth { get; set; }

    public int? FacilityPhotoHomeHieght { get; set; }

    public int? FacilityBannerWidth { get; set; }

    public int? FacilityBannerHieght { get; set; }

    public string HotelNameSys { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string FacilityBannerColorOverlayFrom { get; set; }

    public string FacilityBannerColorOverlayTo { get; set; }

    public string FacilityBannerTablet { get; set; }

    public int? FacilityBannerWidthTablet { get; set; }

    public int? FacilityBannerHieghtTablet { get; set; }

    public string FacilityBannerTabletColorOverlayFrom { get; set; }

    public string FacilityBannerTabletColorOverlayTo { get; set; }

    public string FacilityBannerMobile { get; set; }

    public int? FacilityBannerWidthMobile { get; set; }

    public int? FacilityBannerHieghtMobile { get; set; }

    public string FacilityBannerMobileColorOverlayTo { get; set; }

    public string FacilityBannerMobileColorOverlayFrom { get; set; }

    public string Fb360url { get; set; }

    public string FacilityClassIcon { get; set; }
}
