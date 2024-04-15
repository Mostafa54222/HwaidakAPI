using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwHotelsSpokenLanguage
{
    public int HotelSpokenLanguageId { get; set; }

    public int? HotelId { get; set; }

    public int? SpokenLanguagesId { get; set; }

    public string HotelNameSys { get; set; }

    public string HotelUrl { get; set; }

    public int? SpokenLanguagesPosition { get; set; }

    public string SpokenLanguagesFlag { get; set; }

    public bool? SpokenLanguagesStatus { get; set; }

    public int SpokenLanguagesContentId { get; set; }

    public int? LangId { get; set; }

    public string SpokenLanguages { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public string BookingLang { get; set; }

    public string BookingCurrency { get; set; }
}
