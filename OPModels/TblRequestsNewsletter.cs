using System;
using System.Collections.Generic;

namespace HwaidakAPI.OPModels;

public partial class TblRequestsNewsletter
{
    public int RequestId { get; set; }

    public string Emailaddress { get; set; }

    public DateTime? Startdatetime { get; set; }

    public bool? IsArchived { get; set; }

    public int? HotelId { get; set; }
}
