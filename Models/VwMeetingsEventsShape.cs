using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwMeetingsEventsShape
{
    public int MeetingStyleId { get; set; }

    public int? FacilityId { get; set; }

    public string MeetingStyleNameSys { get; set; }

    public string MeetingStylePhoto { get; set; }

    public int? MeetingStylePoistion { get; set; }

    public bool? MeetingStyleStatus { get; set; }

    public int MeetingStyleContentId { get; set; }

    public int? LangId { get; set; }

    public string MeetingStyleName { get; set; }

    public string MeetingStyleDescription { get; set; }

    public string MeetingStyleBestFor { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public string FacilityUrl { get; set; }
}
