using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwGroupFaq
{
    public int LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public int GroupFaqcontentId { get; set; }

    public int? Expr1 { get; set; }

    public bool? GroupFaqstatusLang { get; set; }

    public string GroupFaqquestion { get; set; }

    public string GroupFaqanswers { get; set; }

    public int GroupFaqid { get; set; }

    public string GroupFaqanswersSys { get; set; }

    public string GroupFaqquestionSys { get; set; }

    public int? GroupFaqposition { get; set; }

    public bool? GroupFaqstatus { get; set; }
}
