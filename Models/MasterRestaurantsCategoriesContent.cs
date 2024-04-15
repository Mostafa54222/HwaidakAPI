using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class MasterRestaurantsCategoriesContent
{
    public int RestaurantCategoryContentId { get; set; }

    public int? RestaurantCategoryId { get; set; }

    public int? LangId { get; set; }

    public string RestaurantCategoryName { get; set; }

    public virtual MasterRestaurantsCategory RestaurantCategory { get; set; }
}
