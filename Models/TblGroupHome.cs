using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHome
{
    public int GroupHomeId { get; set; }

    public string GroupHomePhoto1 { get; set; }

    public string GroupHomeVideoSectionBanner { get; set; }

    public int? GroupHomeVideoSectionBannerWidth { get; set; }

    public int? GroupHomeVideoSectionBannerHeight { get; set; }

    public string GroupHomeVideoSectionBannerMobile { get; set; }

    public int? GroupHomeVideoSectionBannerMobileWidth { get; set; }

    public int? GroupHomeVideoSectionBannerMobileHeight { get; set; }

    public string GroupHomeVideoSectionBannerTablet { get; set; }

    public int? GroupHomeVideoSectionBannerTabletWidth { get; set; }

    public int? GroupHomeVideoSectionBannerTabletHeight { get; set; }

    public int? GroupHomePhoto1Width { get; set; }

    public int? GroupHomePhoto1Height { get; set; }

    public string GroupHomePhoto2 { get; set; }

    public int? GroupHomePhoto2Width { get; set; }

    public int? GroupHomePhoto2Height { get; set; }

    public virtual ICollection<TblGroupHomeContent> TblGroupHomeContents { get; set; } = new List<TblGroupHomeContent>();
}
