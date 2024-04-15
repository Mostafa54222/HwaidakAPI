using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwFaqSection
{
    public int FaqsectionId { get; set; }

    public string SectionName { get; set; }

    public int? LangId { get; set; }

    public bool? SectionStatus { get; set; }

    public int? SectionPosition { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public int? HotelId { get; set; }
}
