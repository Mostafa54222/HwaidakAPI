using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblDocument
{
    public int DocumentId { get; set; }

    public string DocumentName { get; set; }

    public int? LangId { get; set; }

    public double? DocumentSize { get; set; }

    public string DocumentType { get; set; }

    public string DocumentUrl { get; set; }

    public DateTime? CreationDate { get; set; }

    public string DcoumentDescription { get; set; }
}
