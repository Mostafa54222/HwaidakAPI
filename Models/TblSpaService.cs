using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSpaService
{
    public int SpaservicesId { get; set; }

    public int? SpaservicesTypeId { get; set; }

    public string SpaservicesSys { get; set; }

    public int? SpaservicesPosition { get; set; }

    public bool? SpaservicesStatus { get; set; }

    public virtual ICollection<TblSpaServicesContent> TblSpaServicesContents { get; set; } = new List<TblSpaServicesContent>();
}
