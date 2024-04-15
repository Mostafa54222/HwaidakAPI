using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class MasterRestaurantsType
{
    public int RestaurantsTypeId { get; set; }

    public string RestaurantsTypeNameSys { get; set; }

    public string FilterBy { get; set; }

    public string RestaurantsTypePhoto { get; set; }

    public int? RestaurantsTypePhotoWidth { get; set; }

    public int? RestaurantsTypePhotoHieght { get; set; }

    public int? RestaurantsTypeBannerWidth { get; set; }

    public int? RestaurantsTypeBannerHieght { get; set; }

    public string RestaurantsTypeBanner { get; set; }

    public string RestaurantsTypeBannerTablet { get; set; }

    public string RestaurantsTypeBannerMobile { get; set; }

    public int? RestaurantsTypeBannerTabletWidth { get; set; }

    public int? RestaurantsTypeBannerTabletHieght { get; set; }

    public int? RestaurantsTypeBannerMobileWidth { get; set; }

    public int? RestaurantsTypeBannerMobileHieght { get; set; }
}
