using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblOffersContent
{
    public int OfferContentId { get; set; }

    public int? OfferId { get; set; }

    public bool? LangStatus { get; set; }

    public int? LangId { get; set; }

    public string OfferName { get; set; }

    public string ValidityText { get; set; }

    public string OfferDescription { get; set; }

    public string OfferSubTitle1 { get; set; }

    public string OfferSubTitle2 { get; set; }

    public string OfferInclude { get; set; }

    public string OfferTerms { get; set; }

    public string OfferUrl { get; set; }

    public virtual TblOffer Offer { get; set; }
}
