using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblServicesContent
{
    public int ServicesContentId { get; set; }

    public int? ServicesId { get; set; }

    public int? LangId { get; set; }

    public string ServicesName { get; set; }

    public virtual TblService Services { get; set; }
}
