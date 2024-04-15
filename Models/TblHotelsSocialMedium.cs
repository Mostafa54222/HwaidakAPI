using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHotelsSocialMedium
{
    public int SocialId { get; set; }

    public string SocialName { get; set; }

    public string SocialColor { get; set; }

    public string SocialUrl { get; set; }

    public int? SocialPosition { get; set; }

    public bool? SocialStatus { get; set; }

    public string SocialClass { get; set; }

    public int? HotelId { get; set; }
}
