using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class Destination
{
    public int DestinationId { get; set; }

    public int? CountryId { get; set; }

    public string DestinationNameSys { get; set; }

    public string DestinationPhoto { get; set; }

    public string DestinationBanner { get; set; }

    public bool? DestinationStatus { get; set; }

    public string DestinationUrl { get; set; }
}
