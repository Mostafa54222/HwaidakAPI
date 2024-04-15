using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterHotelFacilitiesItem
{
    public int? HotelFacilitiesId { get; set; }

    public string HotelFacilitiesItemNameSys { get; set; }

    public int HotelFacilitiesItemId { get; set; }

    public int? HotelFacilitiesItemPosition { get; set; }

    public bool? HotelFacilitiesItemStatus { get; set; }

    public virtual ICollection<TblMasterHotelFacilitiesItemsContent> TblMasterHotelFacilitiesItemsContents { get; set; } = new List<TblMasterHotelFacilitiesItemsContent>();
}
