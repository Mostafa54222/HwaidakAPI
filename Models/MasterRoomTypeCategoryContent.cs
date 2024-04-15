using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class MasterRoomTypeCategoryContent
{
    public int RoomTypeCategoryLangId { get; set; }

    public int? RoomTypeCategoryId { get; set; }

    public int? LangId { get; set; }

    public string RoomTypeCategoryName { get; set; }

    public virtual MasterRoomTypeCategory RoomTypeCategory { get; set; }
}
