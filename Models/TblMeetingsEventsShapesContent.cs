using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMeetingsEventsShapesContent
{
    public int MeetingStyleContentId { get; set; }

    public int? MeetingStyleId { get; set; }

    public int? LangId { get; set; }

    public string MeetingStyleName { get; set; }

    public string MeetingStyleDescription { get; set; }

    public string MeetingStyleBestFor { get; set; }

    public virtual TblMeetingsEventsShape MeetingStyle { get; set; }
}
