using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSpaGallery
{
    public int FacilitiesFileId { get; set; }

    public int? Spaid { get; set; }

    public string PhotoFile { get; set; }

    public int? PhotoPosition { get; set; }

    public bool? PhotoStatus { get; set; }

    public int? PhotoWidth { get; set; }

    public int? PhotoHieght { get; set; }

    public double? PhotoSize { get; set; }

    public string PhotoFormat { get; set; }

    public double? PhotoRatio { get; set; }
}
