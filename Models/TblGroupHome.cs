using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHome
{
    public int GroupHomeId { get; set; }

    public string GroupHomePhoto1 { get; set; }

    public int? GroupHomePhoto1Width { get; set; }

    public int? GroupHomePhoto1Height { get; set; }

    public string GroupHomePhoto2 { get; set; }

    public int? GroupHomePhoto2Width { get; set; }

    public int? GroupHomePhoto2Height { get; set; }

    public virtual ICollection<TblGroupHomeContent> TblGroupHomeContents { get; set; } = new List<TblGroupHomeContent>();
}
