using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblBlog
{
    public int NewsId { get; set; }

    public int? LangId { get; set; }

    public string NewsTitle { get; set; }

    public string NewsPhoto { get; set; }

    public string NewsBanner { get; set; }

    public bool? NewsStatus { get; set; }

    public DateTime? NewsDateTime { get; set; }

    public string NewsUrl { get; set; }

    public string NewsShortDescription { get; set; }

    public string NewsDetails { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? ItemPhotoWidth { get; set; }

    public int? ItemPhotoHieght { get; set; }

    public int? HotelId { get; set; }
}
