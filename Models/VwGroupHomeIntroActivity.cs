using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGroupHomeIntroActivity
{
    public int LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public bool? GroupHomeIntoActivitiesStatusLang { get; set; }

    public string GroupHomeIntroActivitiesText { get; set; }

    public string GroupHomeIntroActivitiesQuantity { get; set; }

    public int GroupHomeIntroActivitiesContentId { get; set; }

    public int GroupHomeIntroActivitiesId { get; set; }

    public int? GroupHomeIntroActivitiesNumber { get; set; }

    public string GroupHomeIntroActivitiesTextSys { get; set; }

    public bool? GroupHomeActivityStatus { get; set; }

    public int? GroupHomeActivityPosition { get; set; }

    public string GroupHomeIntroActivitiesQuantitySys { get; set; }

    public string LanguageClass { get; set; }
}
