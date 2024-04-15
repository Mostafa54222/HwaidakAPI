using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwAward
{
    public int Awardid { get; set; }

    public string Awardphoto { get; set; }

    public bool? Awardstatus { get; set; }

    public int Awardcontentid { get; set; }

    public int? Langid { get; set; }

    public string Awardtitle { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public int? AwardYear { get; set; }

    public int? HotelId { get; set; }

    public string Awardtitlesys { get; set; }

    public string HotelUrl { get; set; }

    public string AwardDescription { get; set; }

    public string ExternalLink { get; set; }

    public DateTime? AwardDate { get; set; }

    public int? AwardYearCategorId { get; set; }

    public int? RoomPhotoWidth { get; set; }

    public int? RoomPhotoHieght { get; set; }

    public int? Awardposition { get; set; }

    public bool? IsDeleted { get; set; }

    public string HotelNameSys { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? LastUpdate { get; set; }
}
