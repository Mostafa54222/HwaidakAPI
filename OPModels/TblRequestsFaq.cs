using System;
using System.Collections.Generic;

namespace HwaidakAPI.OPModels;

public partial class TblRequestsFaq
{
    public int RequestId { get; set; }

    public DateTime? RequestDate { get; set; }

    public string CustomerName { get; set; }

    public string CustomerEmail { get; set; }

    public string CustomerPhone { get; set; }

    public string CustomerMessage { get; set; }

    public bool? IsArchive { get; set; }

    public int? HotelId { get; set; }
}
