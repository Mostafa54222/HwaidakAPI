using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwHotelsDestinationCm
{
    public int HotelId { get; set; }

    public string HotelNameSys { get; set; }

    public int? DestinationId { get; set; }

    public string HotelFax { get; set; }

    public string DestinationNameSys { get; set; }

    public string DestinationHotel { get; set; }
}
