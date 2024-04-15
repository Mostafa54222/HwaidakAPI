using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwHotelsNearBy
{
    public int HotelNearById { get; set; }

    public int? HotelId { get; set; }

    public string HotelNearByNameSys { get; set; }

    public bool? HotelNearByStatus { get; set; }

    public double? HotelNearByDistance { get; set; }

    public int HotelNearByContentId { get; set; }

    public string HotelNearByName { get; set; }

    public int? LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public string HotelNearByDistanceUnit { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? LastUpdate { get; set; }
}
