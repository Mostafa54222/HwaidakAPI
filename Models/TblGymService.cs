using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGymService
{
    public int GymservicesId { get; set; }

    public string SpaservicesSys { get; set; }

    public int? SpaservicesPosition { get; set; }

    public bool? SpaservicesStatus { get; set; }

    public virtual ICollection<TblGymServicesContent> TblGymServicesContents { get; set; } = new List<TblGymServicesContent>();
}
