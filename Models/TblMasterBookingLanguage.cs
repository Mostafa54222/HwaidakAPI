using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterBookingLanguage
{
    public string BookingLangId { get; set; }

    public string BookingLangName { get; set; }

    public int? BookingLangPosition { get; set; }
}
