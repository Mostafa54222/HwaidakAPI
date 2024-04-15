using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHomeWhyUsContent
{
    public int WhuUsContentId { get; set; }

    public int? WhuUsId { get; set; }

    public int? LangId { get; set; }

    public string WhuUsTitle { get; set; }

    public string WhuUsText { get; set; }

    public virtual TblHomeWhyU WhuUs { get; set; }
}
