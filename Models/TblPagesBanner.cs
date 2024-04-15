using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblPagesBanner
{
    public int PageBannerId { get; set; }

    public string BannerFile { get; set; }

    public bool? BannerStatus { get; set; }

    public int? PageId { get; set; }
}
