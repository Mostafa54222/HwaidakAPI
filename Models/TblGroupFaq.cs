using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupFaq
{
    public int GroupFaqid { get; set; }

    public string GroupFaqquestionSys { get; set; }

    public string GroupFaqanswersSys { get; set; }

    public int? GroupFaqposition { get; set; }

    public bool? GroupFaqstatus { get; set; }

    public virtual ICollection<TblGroupFaqcontent> TblGroupFaqcontents { get; set; } = new List<TblGroupFaqcontent>();
}
