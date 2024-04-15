using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterRoomAmenitiesCategoriesContent
{
    public int RoomAmenitiesCategoryContentId { get; set; }

    public int? RoomAmenitiesCategoryId { get; set; }

    public int? LangId { get; set; }

    public string RoomAmenitiesCategoryName { get; set; }

    public virtual TblMasterRoomAmenitiesCategory RoomAmenitiesCategory { get; set; }
}
