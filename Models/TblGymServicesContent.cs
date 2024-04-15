using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGymServicesContent
{
    public int GymservicesContentId { get; set; }

    public int? GymservicesId { get; set; }

    public string GymservicesName { get; set; }

    public int? LangId { get; set; }

    public string GymservicesDetails { get; set; }

    public string GymservicesExtraNote { get; set; }

    public virtual TblGymService Gymservices { get; set; }
}
