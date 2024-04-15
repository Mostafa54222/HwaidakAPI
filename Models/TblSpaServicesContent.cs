using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSpaServicesContent
{
    public int SpaservicesContentId { get; set; }

    public int? SpaservicesId { get; set; }

    public string SpaservicesName { get; set; }

    public int? LangId { get; set; }

    public string SpaservicesDetails { get; set; }

    public string SpaservicesTime { get; set; }

    public string SpaservicesPrice { get; set; }

    public string SpaservicesExtraNote { get; set; }

    public virtual TblSpaService Spaservices { get; set; }
}
