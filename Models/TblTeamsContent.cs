using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblTeamsContent
{
    public int TeamContentId { get; set; }

    public int? TeamId { get; set; }

    public int? LangId { get; set; }

    public string TeamName { get; set; }

    public string TeamTitlePosition { get; set; }

    public string TeamDetails { get; set; }

    public virtual TblTeam Team { get; set; }
}
