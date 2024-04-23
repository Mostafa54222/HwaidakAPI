using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupPage
{
    public int GroupPagesId { get; set; }

    public string GroupTermsBanner { get; set; }

    public int? GroupTermsBannerWidth { get; set; }

    public int? GroupTermsBannerHeight { get; set; }

    public string GroupTermsBannerMobile { get; set; }

    public int? GroupTermsBannerMobileWidth { get; set; }

    public int? GroupTermsBannerMobileHeight { get; set; }

    public string GroupTermsBannerTablet { get; set; }

    public int? GroupTermsBannerTabletWidth { get; set; }

    public int? GroupTermsBannerTabletHeight { get; set; }

    public string GroupPrivacyBanner { get; set; }

    public int? GroupPrivacyBannerWidth { get; set; }

    public int? GroupPrivacyBannerHeight { get; set; }

    public string GroupPrivacyBannerMobile { get; set; }

    public int? GroupPrivacyBannerMobileWidth { get; set; }

    public int? GroupPrivacyBannerMobileHeight { get; set; }

    public string GroupPrivacyBannerTablet { get; set; }

    public int? GroupPrivacyBannerTabletWidth { get; set; }

    public int? GroupPrivacyBannerTabletHeight { get; set; }

    public string GroupMeetingEventsBanner { get; set; }

    public int? GroupMeetingEventsBannerWidth { get; set; }

    public int? GroupMeetingEventsBannerHeight { get; set; }

    public string GroupMeetingEventsBannerMobile { get; set; }

    public int? GroupMeetingEventsBannerMobileWidth { get; set; }

    public int? GroupMeetingEventsBannerMobileHeight { get; set; }

    public string GroupMeetingEventsBannerTablet { get; set; }

    public int? GroupMeetingEventsBannerTabletWidth { get; set; }

    public int? GroupMeetingEventsBannerTabletHeight { get; set; }

    public string GroupHotelsRessortsBanner { get; set; }

    public int? GroupHotelsRessortsBannerWidth { get; set; }

    public int? GroupHotelsRessortsBannerHeight { get; set; }

    public string GroupHotelsRessortsBannerMobile { get; set; }

    public int? GroupHotelsRessortsBannerMobileWidth { get; set; }

    public int? GroupHotelsRessortsBannerMobileHeight { get; set; }

    public string GroupHotelsRessortsBannerTablet { get; set; }

    public int? GroupHotelsRessortsBannerTabletWidth { get; set; }

    public int? GroupHotelsRessortsBannerTabletHeight { get; set; }

    public string GroupAboutUsBanner { get; set; }

    public int? GroupAboutUsBannerWidth { get; set; }

    public int? GroupAboutUsBannerHeight { get; set; }

    public string GroupAboutUsBannerMobile { get; set; }

    public int? GroupAboutUsBannerMobileWidth { get; set; }

    public int? GroupAboutUsBannerMobileHeigh { get; set; }

    public string GroupAboutUsBannerTablet { get; set; }

    public int? GroupAboutUsBannerTabletWidth { get; set; }

    public int? GroupAboutUsBannerTabletHeight { get; set; }

    public string GroupContactUsBanner { get; set; }

    public int? GroupContactUsBannerWidth { get; set; }

    public int? GroupContactUsBannerHeight { get; set; }

    public string GroupContactUsBannerMobile { get; set; }

    public int? GroupContactUsBannerMobileWidth { get; set; }

    public int? GroupContactUsBannerMobileHeight { get; set; }

    public string GroupContactUsBannerTablet { get; set; }

    public int? GroupContactUsBannerTabletWidth { get; set; }

    public int? GroupContactUsBannerTabletHeight { get; set; }

    public string GroupFaqBanner { get; set; }

    public int? GroupFaqBannerWidth { get; set; }

    public int? GroupFaqBannerHeight { get; set; }

    public string GroupFaqBannerMobile { get; set; }

    public int? GroupFaqBannerMobileWidth { get; set; }

    public int? GroupFaqBannerMobileHeight { get; set; }

    public string GroupFaqBannerTablet { get; set; }

    public int? GroupFaqBannerTabletWidth { get; set; }

    public int? GroupFaqBannerTabletHeight { get; set; }

    public string GroupCarreerBanner { get; set; }

    public int? GroupCarreerBannerWidth { get; set; }

    public int? GroupCarreerBannerHeight { get; set; }

    public string GroupCarreerBannerMobile { get; set; }

    public int? GroupCarreerBannerMobileWidth { get; set; }

    public int? GroupCarreerBannerMobileHeight { get; set; }

    public string GroupCarreerBannerTablet { get; set; }

    public int? GroupCarreerBannerTabletWidth { get; set; }

    public int? GroupCarreerBannerTabletHeight { get; set; }

    public string GroupNewsBanner { get; set; }

    public int? GroupNewsBannerWidth { get; set; }

    public int? GroupNewsBannerHeight { get; set; }

    public string GroupNewsBannerMobile { get; set; }

    public int? GroupNewsBannerMobileWidth { get; set; }

    public int? GroupNewsBannerMobileHeight { get; set; }

    public string GroupNewsBannerTablet { get; set; }

    public int? GroupNewsBannerTabletWidth { get; set; }

    public int? GroupNewsBannerTabletHeight { get; set; }

    public virtual ICollection<TblGroupPagesContent> TblGroupPagesContents { get; set; } = new List<TblGroupPagesContent>();
}
