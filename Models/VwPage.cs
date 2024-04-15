using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwPage
{
    public int PageId { get; set; }

    public string PageBanner { get; set; }

    public string PageUrl { get; set; }

    public int PageContentId { get; set; }

    public int? LangId { get; set; }

    public string PageTitle { get; set; }

    public string PageDetails { get; set; }

    public string PageMetatagTitle { get; set; }

    public string PageMetatagDescription { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageFlag { get; set; }

    public int? HotelId { get; set; }

    public string HotelUrl { get; set; }

    public int? PagePosistion { get; set; }

    public string Updatetext { get; set; }

    public string PageNameSys { get; set; }

    public int? RoomPhotoWidth { get; set; }

    public int? RoomPhotoHieght { get; set; }
}
