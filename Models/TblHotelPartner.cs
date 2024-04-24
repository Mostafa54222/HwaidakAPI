using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHotelPartner
{
    public int HotelPartnerId { get; set; }

    public string HotelPartnerPhoto { get; set; }

    public bool? HotelPartnerStatus { get; set; }

    public int? HotelPartnerPosition { get; set; }
}
