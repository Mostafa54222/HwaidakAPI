using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHomeDiscover
{
    public int DiscoverId { get; set; }

    public string ItemTitleNameSys { get; set; }

    public string ItemPhoto { get; set; }

    public int? ItemPosition { get; set; }

    public bool? ItemStatus { get; set; }

    public virtual ICollection<TblHomeDiscoverContent> TblHomeDiscoverContents { get; set; } = new List<TblHomeDiscoverContent>();
}
