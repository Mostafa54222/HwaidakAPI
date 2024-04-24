using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupFaqcontent
{
    public int GroupFaqcontentId { get; set; }

    public int? GroupFaqid { get; set; }

    public int? LangId { get; set; }

    public bool? GroupFaqstatusLang { get; set; }

    public string GroupFaqquestion { get; set; }

    public string GroupFaqanswers { get; set; }

    public virtual TblGroupFaq GroupFaq { get; set; }
}
