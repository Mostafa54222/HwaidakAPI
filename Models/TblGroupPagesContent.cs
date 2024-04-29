using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupPagesContent
{
    public int GroupPagesContentId { get; set; }

    public int? GroupPagesId { get; set; }

    public int? LangId { get; set; }

    public string GroupSummery { get; set; }

    public string GroupOverview { get; set; }

    public string GroupTerms { get; set; }

    public string GroupTermsTitle { get; set; }

    public string GroupTermsMetatagTitle { get; set; }

    public string GroupTermsMetatagDescription { get; set; }

    public string GroupPrivacy { get; set; }

    public string GroupPrivacyTitle { get; set; }

    public string GroupPrivacyMetatagTitle { get; set; }

    public string GroupPrivacyMetatagDescription { get; set; }

    public string GroupMeetingEvents { get; set; }

    public string GroupMeetingEventsTitle { get; set; }

    public string GroupMeetingEventsMetatagTitle { get; set; }

    public string GroupMeetingEventsMetatagDescription { get; set; }

    public string GroupHotelsRessorts { get; set; }

    public string GroupHotelsRessortsTitle { get; set; }

    public string GroupHotelsRessortsMetatagTitle { get; set; }

    public string GroupHotelsRessortsMetatagDescription { get; set; }

    public string GroupAboutUs { get; set; }

    public string GroupAboutUsTitle { get; set; }

    public string GroupAboutUsMetatagTitle { get; set; }

    public string GroupAboutUsMetatagDescription { get; set; }

    public string GroupContactUs { get; set; }

    public string GroupContactUsTitle { get; set; }

    public string GroupContactUsMetatagTitle { get; set; }

    public string GroupContactUsMetatagDescription { get; set; }

    public string GroupFaq { get; set; }

    public string GroupFaqTitle { get; set; }

    public string GroupFaqMetatagTitle { get; set; }

    public string GroupFaqMetatagDescription { get; set; }

    public string GroupCareer { get; set; }

    public string GroupCareerTitle { get; set; }

    public string GroupCareerMetatagTitle { get; set; }

    public string GroupCareerMetatagDescription { get; set; }

    public string GroupNews { get; set; }

    public string GroupNewsTitle { get; set; }

    public string GroupNewsMetatagTitle { get; set; }

    public string GroupNewsMetatagDescription { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public virtual TblGroupPage GroupPages { get; set; }
}
