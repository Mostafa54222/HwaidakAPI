using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeVideoSectionContent
{
    public int GroupHomeVideoSectionContentId { get; set; }

    public int? GroupHomeVideoSectionId { get; set; }

    public int? LangId { get; set; }

    public bool? GroupHomeVideoSectionStatusLang { get; set; }

    public string GroupHomeVideoSectionTitleTop { get; set; }

    public string GroupHomeVideoSectionTitle { get; set; }

    public virtual TblGroupHomeVideoSection GroupHomeVideoSection { get; set; }
}
