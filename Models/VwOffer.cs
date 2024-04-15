using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwOffer
{
    public int Offerid { get; set; }

    public string OfferNameSys { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public bool? OfferStatus { get; set; }

    public int? OfferPosition { get; set; }

    public string OfferPhoto { get; set; }

    public string OfferBanner { get; set; }

    public string OfferUrl { get; set; }

    public int OfferContentId { get; set; }

    public bool? LangStatus { get; set; }

    public int? LangId { get; set; }

    public string OfferName { get; set; }

    public string OfferDescription { get; set; }

    public string OfferSubTitle1 { get; set; }

    public string OfferSubTitle2 { get; set; }

    public string OfferInclude { get; set; }

    public string OfferTerms { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public string OfferBookingUrl { get; set; }

    public int? HotelId { get; set; }

    public bool? IsDisplayDates { get; set; }

    public string ValidityText { get; set; }

    public bool? IsChildAllowed { get; set; }

    public string PromoCode { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string HotelNameSys { get; set; }

    public string HotelUrl { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? OfferPhotoWidth { get; set; }

    public int? OfferPhotoHieght { get; set; }

    public int? OfferBannerWidth { get; set; }

    public int? OfferBannerHieght { get; set; }
}
