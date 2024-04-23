using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGroupHome
{
    public string LanguageName { get; set; }

    public string LanguageAbbreviation { get; set; }

    public string LanguageFlag { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public int? LangId { get; set; }

    public int GroupHomeContentId { get; set; }

    public int GroupHomeId { get; set; }

    public string GroupHomePhoto1 { get; set; }

    public int? GroupHomePhoto1Width { get; set; }

    public int? GroupHomePhoto1Height { get; set; }

    public string GroupHomePhoto2 { get; set; }

    public int? GroupHomePhoto2Width { get; set; }

    public int? GroupHomePhoto2Height { get; set; }

    public bool? GroupHomeStatusLang { get; set; }

    public string GroupHomeTitleTop { get; set; }

    public string GroupHomeTitle { get; set; }

    public string GroupHomeText { get; set; }

    public string GroupHomeSubText { get; set; }

    public string GroupHomeButton { get; set; }

    public string GroupHomeButtonUrl { get; set; }
}
