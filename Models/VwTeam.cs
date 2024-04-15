using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwTeam
{
    public int TeamId { get; set; }

    public string TeamNameSys { get; set; }

    public string TeamPhoto { get; set; }

    public int? TeamPosition { get; set; }

    public bool? TeamStatus { get; set; }

    public string TeamEmail { get; set; }

    public string TeamMobile { get; set; }

    public int TeamContentId { get; set; }

    public int? LangId { get; set; }

    public string TeamName { get; set; }

    public string TeamTitlePosition { get; set; }

    public string TeamDetails { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool? IsMoreDetails { get; set; }

    public string TeamUrl { get; set; }

    public double? TeamPhotoWidth { get; set; }

    public double? TeamPhotoHieght { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? HotelId { get; set; }

    public string HotelNameSys { get; set; }

    public string HotelUrl { get; set; }
}
