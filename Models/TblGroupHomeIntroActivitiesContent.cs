using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeIntroActivitiesContent
{
    public int GroupHomeIntroActivitiesContentId { get; set; }

    public int? GroupHomeIntroActivitiesId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupHomeIntoActivitiesStatusLang { get; set; }

    public string GroupHomeIntroActivitiesText { get; set; }
}
