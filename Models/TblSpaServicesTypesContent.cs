using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSpaServicesTypesContent
{
    public int SpaservicesTypeContentId { get; set; }

    public int? SpaservicesTypeId { get; set; }

    public string SpaservicesTypeName { get; set; }

    public int? LangId { get; set; }

    public string SpaservicesTypeExtraText { get; set; }

    public virtual TblSpaServicesType SpaservicesType { get; set; }
}
