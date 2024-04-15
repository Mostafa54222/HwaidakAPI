using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMeetingsEventsShape
{
    public int MeetingStyleId { get; set; }

    public int? FacilityId { get; set; }

    public string MeetingStyleNameSys { get; set; }

    public string MeetingStylePhoto { get; set; }

    public int? MeetingStylePoistion { get; set; }

    public bool? MeetingStyleStatus { get; set; }

    public virtual ICollection<TblMeetingsEventsShapesContent> TblMeetingsEventsShapesContents { get; set; } = new List<TblMeetingsEventsShapesContent>();
}
