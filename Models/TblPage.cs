using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblPage
{
    public int PageId { get; set; }

    public int? HotelId { get; set; }

    public int? PagePosistion { get; set; }

    public string PageNameSys { get; set; }

    public string PageBanner { get; set; }

    public string PageUrl { get; set; }

    public string Updatetext { get; set; }

    public int? RoomPhotoWidth { get; set; }

    public int? RoomPhotoHieght { get; set; }

    public virtual ICollection<TblPagesContent> TblPagesContents { get; set; } = new List<TblPagesContent>();
}
