using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSpa
{
    public int SpaId { get; set; }

    public int? HotelId { get; set; }

    public string FacilityNameSys { get; set; }

    public string FacilityUrl { get; set; }

    public string FacilityPhoto { get; set; }

    public string FacilityBanner { get; set; }

    public bool? FacilityStatus { get; set; }

    public bool? IsMoreDetails { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? FacilityPosition { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? FacilityPhotoWidth { get; set; }

    public int? FacilityPhotoHieght { get; set; }

    public int? FacilityBannerWidth { get; set; }

    public int? FacilityBannerHieght { get; set; }

    public string FacilityBannerTablet { get; set; }

    public int? FacilityBannerWidthTablet { get; set; }

    public int? FacilityBannerHieghtTablet { get; set; }

    public string FacilityBannerTabletColorOverlayFrom { get; set; }

    public string FacilityBannerTabletColorOverlayTo { get; set; }

    public string FacilityBannerMobile { get; set; }

    public int? FacilityBannerWidthMobile { get; set; }

    public int? FacilityBannerHieghtMobile { get; set; }

    public string FacilityBannerMobileColorOverlayFrom { get; set; }

    public string FacilityBannerMobileColorOverlayTo { get; set; }

    public string Fb360url { get; set; }

    public virtual ICollection<TblSpaContent> TblSpaContents { get; set; } = new List<TblSpaContent>();
}
