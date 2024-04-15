using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterHotelFacility
{
    public int HotelFacilitiesId { get; set; }

    public string HotelFacilitiesNameSys { get; set; }

    public string HotelFacilitiesIcon { get; set; }

    public int? HotelFacilitiesPoisition { get; set; }

    public bool? HotelFacilitiesStatus { get; set; }

    public virtual ICollection<TblMasterHotelFacilitiesContent> TblMasterHotelFacilitiesContents { get; set; } = new List<TblMasterHotelFacilitiesContent>();
}
