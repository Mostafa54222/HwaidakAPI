using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class MasterRestaurantsTypeContent
{
    public int RestaurantsTypeLangId { get; set; }

    public int? RestaurantsTypeId { get; set; }

    public int? LangId { get; set; }

    public string RestaurantsTypeName { get; set; }

    public string RestaurantsTypeIntro { get; set; }
}
