using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblNewsContent
{
    public int NewsContentId { get; set; }

    public int? NewsId { get; set; }

    public int? LangId { get; set; }

    public bool? NewsStatusLang { get; set; }

    public string NewsTitle { get; set; }

    public string NewsShortDescription { get; set; }

    public string NewsDetails { get; set; }

    public string NewsDateTime { get; set; }

    public virtual TblNews News { get; set; }
}
