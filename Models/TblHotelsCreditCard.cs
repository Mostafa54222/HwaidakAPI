using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHotelsCreditCard
{
    public int HotelCreditCardId { get; set; }

    public int? HotelId { get; set; }

    public int? CreditCardId { get; set; }
}
