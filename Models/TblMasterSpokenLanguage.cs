using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterSpokenLanguage
{
    public int SpokenLanguagesId { get; set; }

    public string SpokenLanguagesSys { get; set; }

    public int? SpokenLanguagesPosition { get; set; }

    public string SpokenLanguagesFlag { get; set; }

    public bool? SpokenLanguagesStatus { get; set; }

    public virtual ICollection<TblMasterSpokenLanguagesContent> TblMasterSpokenLanguagesContents { get; set; } = new List<TblMasterSpokenLanguagesContent>();
}
