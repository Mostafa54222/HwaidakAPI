using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGroupHomeIntro
{
    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public int? LangId { get; set; }

    public int GroupHomeIntroContentId { get; set; }

    public bool? GroupHomeIntroStatusLang { get; set; }

    public string GroupHomeIntroTitleTop { get; set; }

    public string GroupHomeIntroTitle { get; set; }

    public string GroupHomeIntroText { get; set; }

    public int GroupHomeIntroId { get; set; }

    public string GroupHomeIntroTitleSys { get; set; }

    public string GroupHomeIntroTitleTopSys { get; set; }

    public string GroupHomeIntroTextSys { get; set; }
}
