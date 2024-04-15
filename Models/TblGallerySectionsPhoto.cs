using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGallerySectionsPhoto
{
    public int PhotoId { get; set; }

    public int? GallerySectionId { get; set; }

    public string PhotoTitleSys { get; set; }

    public string PhotoFile { get; set; }

    public bool? PhotoStatus { get; set; }

    public int? PhotoPosition { get; set; }

    public int? PhotoWidth { get; set; }

    public int? PhotoHieght { get; set; }

    public double? PhotoSize { get; set; }

    public string PhotoFormat { get; set; }

    public double? PhotoRatio { get; set; }

    public virtual ICollection<TblGallerySectionsPhotosContent> TblGallerySectionsPhotosContents { get; set; } = new List<TblGallerySectionsPhotosContent>();
}
