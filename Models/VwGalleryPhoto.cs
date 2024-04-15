using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGalleryPhoto
{
    public int PhotoId { get; set; }

    public int? GallerySectionId { get; set; }

    public string PhotoFile { get; set; }

    public bool? PhotoStatus { get; set; }

    public int? PhotoPosition { get; set; }

    public int PhotoContentId { get; set; }

    public int? LangId { get; set; }

    public string PhotoTitle { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? GalleryStatus { get; set; }

    public int? HotelId { get; set; }

    public string HotelUrl { get; set; }

    public string GallerySectionNameSys { get; set; }

    public int? PhotoWidth { get; set; }

    public int? PhotoHieght { get; set; }

    public double? PhotoSize { get; set; }

    public string PhotoFormat { get; set; }

    public double? PhotoRatio { get; set; }
}
