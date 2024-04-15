using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterHotelFacilitiesContent
{
    public int HotelFacilitiesContentId { get; set; }

    public int? HotelFacilitiesId { get; set; }

    public int? LangId { get; set; }

    public string HotelFacilitiesName { get; set; }

    public virtual TblMasterHotelFacility HotelFacilities { get; set; }
}
