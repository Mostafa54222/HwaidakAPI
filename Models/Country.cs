using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryNameSys { get; set; }

    public string CountryUrl { get; set; }

    public bool? CountryStatus { get; set; }
}
