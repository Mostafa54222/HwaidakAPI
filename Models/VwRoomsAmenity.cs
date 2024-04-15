using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwRoomsAmenity
{
    public int RoomRoomAmenitiesId { get; set; }

    public int? RoomAmenitiesId { get; set; }

    public int? RoomId { get; set; }

    public string RoomAmenitiesPhoto { get; set; }

    public bool? RoomAmenitiesStatus { get; set; }

    public int? RoomAmenitiesPosition { get; set; }

    public string RoomAmenitiesName { get; set; }

    public int? LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageAbbreviation { get; set; }

    public string LanguageFlag { get; set; }

    public bool? LangStatus { get; set; }

    public int? RoomAmenitiesCategoryId { get; set; }

    public string RoomAmenitiesCategoryName { get; set; }

    public int RoomAmenitiesCategoryContentId { get; set; }
}
