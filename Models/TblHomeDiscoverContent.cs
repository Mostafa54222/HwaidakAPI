using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHomeDiscoverContent
{
    public int DiscoverContentId { get; set; }

    public int? DiscoverId { get; set; }

    public int? LangId { get; set; }

    public bool? LangStatus { get; set; }

    public string ItemTitleName { get; set; }

    public string ItemUrl { get; set; }

    public virtual TblHomeDiscover Discover { get; set; }
}
