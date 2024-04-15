using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class DestinationsContent
{
    public int DestinationContentId { get; set; }

    public int? DestinationId { get; set; }

    public int? LangId { get; set; }

    public string DestinationName { get; set; }

    public string DestinationIntro { get; set; }

    public string DestinationDetails { get; set; }
}
