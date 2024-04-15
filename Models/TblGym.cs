using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGym
{
    public int GymId { get; set; }

    public int? HotelId { get; set; }

    public string FacilityNameSys { get; set; }

    public string FacilityUrl { get; set; }

    public string FacilityPhoto { get; set; }

    public string FacilityBanner { get; set; }

    public bool? FacilityStatus { get; set; }

    public virtual ICollection<TblGymContent> TblGymContents { get; set; } = new List<TblGymContent>();
}
