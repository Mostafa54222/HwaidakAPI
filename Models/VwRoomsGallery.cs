using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwRoomsGallery
{
    public int RoomFileId { get; set; }

    public int? RoomId { get; set; }

    public string PhotoFile { get; set; }

    public bool? PhotoStatus { get; set; }

    public int? PhotoPosition { get; set; }

    public string RoomUrl { get; set; }

    public string HotelUrl { get; set; }

    public int? PhotoWidth { get; set; }

    public int? PhotoHieght { get; set; }

    public double? PhotoSize { get; set; }

    public string PhotoFormat { get; set; }

    public double? PhotoRatio { get; set; }

    public int HotelId { get; set; }
}
