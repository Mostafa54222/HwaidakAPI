using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwDocument
{
    public string DocumentName { get; set; }

    public int DocumentId { get; set; }

    public int? LangId { get; set; }

    public double? DocumentSize { get; set; }

    public string DocumentType { get; set; }

    public string DocumentUrl { get; set; }

    public DateTime? CreationDate { get; set; }

    public string DcoumentDescription { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }
}
