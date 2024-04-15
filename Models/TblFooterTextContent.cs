using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblFooterTextContent
{
    public int FooterContentId { get; set; }

    public int? FooterId { get; set; }

    public int? LangId { get; set; }

    public string FooterText { get; set; }

    public virtual TblFooterText Footer { get; set; }
}
