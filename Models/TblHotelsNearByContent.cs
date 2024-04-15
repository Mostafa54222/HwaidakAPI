using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHotelsNearByContent
{
    public int HotelNearByContentId { get; set; }

    public int? HotelNearById { get; set; }

    public string HotelNearByName { get; set; }

    public int? LangId { get; set; }

    public string HotelNearByDistanceUnit { get; set; }

    public virtual TblHotelsNearBy HotelNearBy { get; set; }
}
