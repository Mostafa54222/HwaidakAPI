using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGalleryActive
{
    public int GallerySectionId { get; set; }

    public int? GalleryPosition { get; set; }

    public int? HotelId { get; set; }

    public int GallerySectionContentId { get; set; }

    public string GallerySectionName { get; set; }

    public int LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public int? PhotoCount { get; set; }

    public string HotelUrl { get; set; }
}
