using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterCreditCard
{
    public int CreditCardId { get; set; }

    public string CreditCardNameSys { get; set; }

    public string CreditCardIcon { get; set; }

    public int? CreditCardPosition { get; set; }

    public bool? CreditCardStatus { get; set; }

    public virtual ICollection<TblMasterCreditCardsContent> TblMasterCreditCardsContents { get; set; } = new List<TblMasterCreditCardsContent>();
}
