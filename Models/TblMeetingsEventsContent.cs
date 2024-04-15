using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMeetingsEventsContent
{
    public int FacilityContentId { get; set; }

    public int? FacilityId { get; set; }

    public int? LangId { get; set; }

    public bool? FacilityStatusLang { get; set; }

    public string FacilityName { get; set; }

    public string FacilitySummery { get; set; }

    public string FacilityDetails { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public string MeetingSize { get; set; }

    public string MeetingLength { get; set; }

    public string MeetingWidths { get; set; }

    public string MeetingCellingHeight { get; set; }

    public string MeetingCapacity { get; set; }

    public virtual TblMeetingsEvent Facility { get; set; }
}
