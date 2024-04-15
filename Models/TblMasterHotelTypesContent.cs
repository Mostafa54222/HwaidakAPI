using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterHotelTypesContent
{
    public int HotelTypeContentId { get; set; }

    public int? HotelTypeId { get; set; }

    public int? LangId { get; set; }

    public string HotelTypeName { get; set; }
}
