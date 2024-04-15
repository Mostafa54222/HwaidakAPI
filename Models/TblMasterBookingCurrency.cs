using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterBookingCurrency
{
    public string BookingCurrencyCode { get; set; }

    public string BookingCurrencyName { get; set; }

    public int? BookingCurrencyPosition { get; set; }
}
