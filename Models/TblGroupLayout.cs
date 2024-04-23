using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupLayout
{
    public int GroupLayoutId { get; set; }

    public string GroupAddress { get; set; }

    public string GroupMail { get; set; }

    public string GroupPhone { get; set; }

    public string GroupSummery { get; set; }

    public string GroupLogo { get; set; }
}
