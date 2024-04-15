using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblExtraPage
{
    public int PageId { get; set; }

    public int? HotelId { get; set; }

    public int? PagePosistion { get; set; }

    public string PageNameSys { get; set; }

    public string PageBanner { get; set; }

    public string PageUrl { get; set; }

    public bool? PageStatus { get; set; }

    public virtual ICollection<TblExtraPagesContent> TblExtraPagesContents { get; set; } = new List<TblExtraPagesContent>();
}
