using System;
using System.Collections.Generic;

namespace HwaidakAPI.OPModels;

public partial class TblRequestsMeeting
{
    public int RequestId { get; set; }

    public DateTime? RequestDate { get; set; }

    public string Numberofattendees { get; set; }

    public string Numberofguestroomsrequired { get; set; }

    public string PreferredSetup { get; set; }

    public DateTime? EventStartDate { get; set; }

    public DateTime? EventEndDate { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string EmailAddress { get; set; }

    public string CompanyName { get; set; }

    public string JobTitle { get; set; }

    public string TelephoneNumber { get; set; }

    public string SpecialRequest { get; set; }

    public bool? IsArchive { get; set; }

    public int? HotelId { get; set; }
}
