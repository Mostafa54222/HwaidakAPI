using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwMasterRoomAmenity
{
    public int RoomAmenitiesId { get; set; }

    public string RoomAmenitiesSys { get; set; }

    public string RoomAmenitiesPhoto { get; set; }

    public bool? RoomAmenitiesStatus { get; set; }

    public int? RoomAmenitiesPosition { get; set; }

    public int RoomAmenitiesContentId { get; set; }

    public int? LangId { get; set; }

    public string RoomAmenitiesName { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public string LanguageClass { get; set; }

    public bool? LangStatus { get; set; }

    public int? RoomPhotoHieght { get; set; }

    public int? RoomPhotoWidth { get; set; }

    public string RoomAmenitiesIconFont { get; set; }
}
