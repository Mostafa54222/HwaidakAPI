using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeIntroContent
{
    public int GroupHomeIntroContentId { get; set; }

    public int? GroupHomeIntroId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupHomeIntroStatusLang { get; set; }

    public string GroupHomeIntroTitleTop { get; set; }

    public string GroupHomeIntroTitle { get; set; }

    public string GroupHomeIntroText { get; set; }

    public virtual TblGroupHomeIntro GroupHomeIntro { get; set; }
}
