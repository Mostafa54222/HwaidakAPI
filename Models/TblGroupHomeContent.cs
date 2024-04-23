using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeContent
{
    public int GroupHomeContentId { get; set; }

    public int? GroupHomeId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupHomeStatusLang { get; set; }

    public string GroupHomeTitleTop { get; set; }

    public string GroupHomeTitle { get; set; }

    public string GroupHomeText { get; set; }

    public string GroupHomeSubText { get; set; }

    public string GroupHomeButton { get; set; }

    public string GroupHomeButtonUrl { get; set; }

    public virtual TblGroupHome GroupHome { get; set; }
}
