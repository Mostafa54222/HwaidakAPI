using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGroupHomeVideoSection
{
    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public int GroupHomeVideoSectionContentId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupHomeVideoSectionStatusLang { get; set; }

    public string GroupHomeVideoSectionTitleTop { get; set; }

    public string GroupHomeVideoSectionTitle { get; set; }

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
}
