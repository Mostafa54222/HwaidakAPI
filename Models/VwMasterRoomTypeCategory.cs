using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwMasterRoomTypeCategory
{
    public int RoomTypeCategoryId { get; set; }

    public string FilterBy { get; set; }

    public string RoomTypeCategoryName { get; set; }

    public int? LangId { get; set; }

    public int RoomTypeCategoryLangId { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }
}
