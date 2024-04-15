using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterHotelFacilitiesItemsContent
{
    public int HotelFacilitiesItemContentId { get; set; }

    public int? HotelFacilitiesItemId { get; set; }

    public int? LangId { get; set; }

    public string HotelFacilitiesItemName { get; set; }

    public string HotelFacilitiesItemExtraText { get; set; }

    public virtual TblMasterHotelFacilitiesItem HotelFacilitiesItem { get; set; }
}
