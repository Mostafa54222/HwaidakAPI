using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwHotelsCreditCard
{
    public int HotelCreditCardId { get; set; }

    public int? HotelId { get; set; }

    public int? CreditCardId { get; set; }

    public int Expr1 { get; set; }

    public string HotelUrl { get; set; }

    public string CreditCardIcon { get; set; }

    public int? CreditCardPosition { get; set; }

    public bool? CreditCardStatus { get; set; }

    public int CreditCardContentId { get; set; }

    public int? LangId { get; set; }

    public string CreditCardName { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string LanguageClass { get; set; }

    public string BookingLang { get; set; }

    public string BookingCurrency { get; set; }
}
