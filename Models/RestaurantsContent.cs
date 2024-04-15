using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class RestaurantsContent
{
    public int RestaurantContentId { get; set; }

    public int? RestaurantId { get; set; }

    public int? LangId { get; set; }

    public string RestaurantName { get; set; }

    public string RestaurantSummery { get; set; }

    public string RestaurantDetails { get; set; }

    public bool? RestaurantStatusLang { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public string Openinghours { get; set; }

    public string DressCode { get; set; }

    public string RestaurantCuisine { get; set; }

    public string RestaurantOpenFor { get; set; }

    public string RestaurantMenu { get; set; }

    public string RestaurantNote { get; set; }

    public virtual Restaurant Restaurant { get; set; }
}
