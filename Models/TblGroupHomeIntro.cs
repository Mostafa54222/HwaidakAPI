using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeIntro
{
    public int GroupHomeIntroId { get; set; }

    public string GroupHomeIntroTitleTopSys { get; set; }

    public string GroupHomeIntroTitleSys { get; set; }

    public string GroupHomeIntroTextSys { get; set; }

    public virtual ICollection<TblGroupHomeIntroContent> TblGroupHomeIntroContents { get; set; } = new List<TblGroupHomeIntroContent>();
}
