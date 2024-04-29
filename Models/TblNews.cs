using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblNews
{
    public int NewsId { get; set; }

    public string NewsTitleSys { get; set; }

    public string NewsPhoto { get; set; }

    public bool? NewsStatus { get; set; }

    public string NewsUrl { get; set; }

    public int? LangId { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ItemPhotoWidth { get; set; }

    public int? ItemPhotoHieght { get; set; }

    public int? HotelId { get; set; }

    public string NewsItemBanner { get; set; }

    public int? NewsItemBannerPhotoHieght { get; set; }

    public int? NewsItemBannerPhotoWidth { get; set; }

    public string NewsItemBannerTablet { get; set; }

    public int? NewsItemBannerTabletHieght { get; set; }

    public int? NewsItemBannerTabletWidth { get; set; }

    public string NewsItemBannerMobile { get; set; }

    public int? NewsItemBannerMobileWidth { get; set; }

    public int? NewsItemBannerMobileHieght { get; set; }

    public virtual ICollection<TblNewsContent> TblNewsContents { get; set; } = new List<TblNewsContent>();
}
