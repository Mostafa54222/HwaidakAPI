using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHotelsFacility
{
    public int FacilitiesPerHotelId { get; set; }

    public int? HotelId { get; set; }

    public int? HotelFacilitiesItemId { get; set; }
}
