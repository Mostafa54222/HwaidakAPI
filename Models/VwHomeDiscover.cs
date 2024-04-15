using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwHomeDiscover
{
    public int DiscoverId { get; set; }

    public string ItemTitleNameSys { get; set; }

    public string ItemPhoto { get; set; }

    public int? ItemPosition { get; set; }

    public bool? ItemStatus { get; set; }

    public int DiscoverContentId { get; set; }

    public int? LangId { get; set; }

    public bool? LangStatus { get; set; }

    public string ItemTitleName { get; set; }

    public string ItemUrl { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }
}
