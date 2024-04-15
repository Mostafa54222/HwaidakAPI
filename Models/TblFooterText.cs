using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblFooterText
{
    public int FooterId { get; set; }

    public virtual ICollection<TblFooterTextContent> TblFooterTextContents { get; set; } = new List<TblFooterTextContent>();
}
