using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMeetingsEventsGallery
{
    public int FacilitiesFileId { get; set; }

    public int? FacilitiesId { get; set; }

    public string PhotoFile { get; set; }

    public int? PhotoPosition { get; set; }

    public bool? PhotoStatus { get; set; }

    public int? PhotoWidth { get; set; }

    public int? PhotoHieght { get; set; }

    public virtual TblMeetingsEvent Facilities { get; set; }
}
