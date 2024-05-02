using System;
using System.Collections.Generic;

namespace HwaidakAPI.OPModels;

public partial class TblRequestsWedding
{
    public int WeddingId { get; set; }

    public DateTime? RequestDate { get; set; }

    public string WeddingPlace { get; set; }

    public DateTime? WeddingDate { get; set; }

    public DateTime? AlternativeWeddingDate { get; set; }

    public bool? DatesFlexible { get; set; }

    public int? NumberOfAttendees { get; set; }

    public bool? GuestRoomsRequired { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Telephone { get; set; }

    public string SpecialRequest { get; set; }

    public bool? IsArchive { get; set; }

    public int? HotelId { get; set; }
}
