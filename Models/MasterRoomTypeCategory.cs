using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class MasterRoomTypeCategory
{
    public int RoomTypeCategoryId { get; set; }

    public string RoomTypeCategoryNameSys { get; set; }

    public string FilterBy { get; set; }

    public virtual ICollection<MasterRoomTypeCategoryContent> MasterRoomTypeCategoryContents { get; set; } = new List<MasterRoomTypeCategoryContent>();
}
