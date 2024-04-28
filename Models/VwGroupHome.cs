using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGroupHome
{
    public int LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public int GroupHomeContentId { get; set; }

    public bool? GroupHomeStatusLang { get; set; }

    public string GroupHomeIntroTitleTop { get; set; }

    public string GroupHomeIntroTitle { get; set; }

    public string GroupHomeIntroText { get; set; }

    public string GroupHomeIntroButton { get; set; }

    public string GroupHomeHotelTitleTop { get; set; }

    public string GroupHomeHotelTitle { get; set; }

    public string GroupHomeNewsTitleTop { get; set; }

    public string GroupHomeNewsTitle { get; set; }

    public string GroupHomeSecondSectionTitleTop { get; set; }

    public string GroupHomeSecondSectionTitle { get; set; }

    public string GroupHomeSecondSectionText { get; set; }

    public string GroupHomeSecondSectionSubText { get; set; }

    public string GroupHomeSecondSectionButton { get; set; }

    public string GroupHomeVideoSectionTitle { get; set; }

    public string GroupHomeVideoSectionTitleTop { get; set; }

    public string GroupHomeIntroButtonUrl { get; set; }

    public string GroupHomeVideoUrl { get; set; }

    public string GroupHomeSecondSectionButtonUrl { get; set; }

    public int GroupHomeId { get; set; }

    public string GroupHomePhoto1 { get; set; }

    public string GroupHomeVideoSectionBanner { get; set; }

    public int? GroupHomeVideoSectionBannerWidth { get; set; }

    public int? GroupHomeVideoSectionBannerHeight { get; set; }

    public string GroupHomeVideoSectionBannerMobile { get; set; }

    public int? GroupHomeVideoSectionBannerMobileWidth { get; set; }

    public int? GroupHomeVideoSectionBannerMobileHeight { get; set; }

    public string GroupHomeVideoSectionBannerTablet { get; set; }

    public int? GroupHomeVideoSectionBannerTabletHeight { get; set; }

    public int? GroupHomeVideoSectionBannerTabletWidth { get; set; }

    public int? GroupHomePhoto1Width { get; set; }

    public int? GroupHomePhoto1Height { get; set; }

    public string GroupHomePhoto2 { get; set; }

    public int? GroupHomePhoto2Width { get; set; }

    public int? GroupHomePhoto2Height { get; set; }

    public string GroupGetDirectionLink { get; set; }

    public string GroupGoogleMap { get; set; }

    public string GroupContactUsIcon { get; set; }

    public string GroupContactUsTitleTop { get; set; }

    public string GroupContactUsTitle { get; set; }

    public string GroupContactUsSummery { get; set; }
}
