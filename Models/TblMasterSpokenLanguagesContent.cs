using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblMasterSpokenLanguagesContent
{
    public int SpokenLanguagesContentId { get; set; }

    public int? SpokenLanguagesId { get; set; }

    public int? LangId { get; set; }

    public string SpokenLanguages { get; set; }

    public virtual TblMasterSpokenLanguage SpokenLanguagesNavigation { get; set; }
}
