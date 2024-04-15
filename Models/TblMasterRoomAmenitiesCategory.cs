using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterRoomAmenitiesCategory
{
    public int RoomAmenitiesCategoryId { get; set; }

    public string RoomAmenitiesCategoryNameSys { get; set; }

    public virtual ICollection<TblMasterRoomAmenitiesCategoriesContent> TblMasterRoomAmenitiesCategoriesContents { get; set; } = new List<TblMasterRoomAmenitiesCategoriesContent>();
}
