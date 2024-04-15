using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSiteContact
{
    public int ContactId { get; set; }

    public int? LangId { get; set; }

    public string SiteTel { get; set; }

    public string SiteFax { get; set; }

    public string SiteAddress { get; set; }

    public string SiteEmail { get; set; }

    public string SiteMobile { get; set; }
}
