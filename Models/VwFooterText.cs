using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwFooterText
{
    public int FooterId { get; set; }

    public int FooterContentId { get; set; }

    public int? LangId { get; set; }

    public string FooterText { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }
}
