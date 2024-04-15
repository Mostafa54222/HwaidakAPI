using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwAwardsFilter
{
    public int? YearCount { get; set; }

    public int HotelId { get; set; }

    public string HotelUrl { get; set; }

    public int AwardYearCategorId { get; set; }

    public string AwardYearCategoryName { get; set; }

    public int? AwardPosition { get; set; }
}
