using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeVideoSection
{
    public int GroupHomeVideoSectionId { get; set; }

    public string GroupHomeVideoSectionTitleTopSys { get; set; }

    public string GroupHomeVideoSectionTitleSys { get; set; }

    public string GroupHomeVideoSectionBanner { get; set; }

    public int? GroupHomeVideoSectionBannerWidth { get; set; }

    public int? GroupHomeVideoSectionBannerHeight { get; set; }

    public string GroupHomeVideoSectionBannerMobile { get; set; }

    public int? GroupHomeVideoSectionBannerMobileWidth { get; set; }

    public int? GroupHomeVideoSectionBannerMobileHeight { get; set; }

    public string GroupHomeVideoSectionBannerTablet { get; set; }

    public int? GroupHomeVideoSectionBannerTabletWidth { get; set; }

    public int? GroupHomeVideoSectionBannerTabletHeight { get; set; }

    public string GroupHomeVideoUrl { get; set; }

    public virtual ICollection<TblGroupHomeVideoSectionContent> TblGroupHomeVideoSectionContents { get; set; } = new List<TblGroupHomeVideoSectionContent>();
}
