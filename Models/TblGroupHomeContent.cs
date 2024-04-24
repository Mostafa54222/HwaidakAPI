using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeContent
{
    public int GroupHomeContentId { get; set; }

    public int? GroupHomeId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupHomeStatusLang { get; set; }

    public string GroupHomeIntroTitleTop { get; set; }

    public string GroupHomeIntroTitle { get; set; }

    public string GroupHomeIntroText { get; set; }

    public string GroupHomeIntroButton { get; set; }

    public string GroupHomeHotelTitleTop { get; set; }

    public string GroupHomeHotelTitle { get; set; }

    public string GroupHomeNewsTitleTop { get; set; }

    public string GroupHomeNewsTitle { get; set; }

    public string GroupHomeSecondSectionTitleTop { get; set; }

    public string GroupHomeSecondSectionTitle { get; set; }

    public string GroupHomeSecondSectionText { get; set; }

    public string GroupHomeSecondSectionSubText { get; set; }

    public string GroupHomeSecondSectionButton { get; set; }

    public string GroupHomeVideoSectionTitleTop { get; set; }

    public string GroupHomeVideoSectionTitle { get; set; }

    public string GroupHomeIntroButtonUrl { get; set; }

    public string GroupHomeVideoUrl { get; set; }

    public string GroupHomeSecondSectionButtonUrl { get; set; }

    public virtual TblGroupHome GroupHome { get; set; }
}
