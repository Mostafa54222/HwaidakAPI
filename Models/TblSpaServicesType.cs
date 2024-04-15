using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSpaServicesType
{
    public int SpaservicesTypeId { get; set; }

    public int? SpaId { get; set; }

    public string SpaservicesTypeNameSys { get; set; }

    public bool? SpaservicesTypeStatus { get; set; }

    public int? SpaservicesTypePosition { get; set; }

    public virtual ICollection<TblSpaServicesTypesContent> TblSpaServicesTypesContents { get; set; } = new List<TblSpaServicesTypesContent>();
}
