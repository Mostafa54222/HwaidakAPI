using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblServicesHotel
{
    public int HotelServicesId { get; set; }

    public int? HotelId { get; set; }

    public int? ServicesId { get; set; }
}
