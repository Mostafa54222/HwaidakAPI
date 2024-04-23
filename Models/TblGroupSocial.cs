using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupSocial
{
    public int GroupSocialId { get; set; }

    public string SocialName { get; set; }

    public string SocialColor { get; set; }

    public string SocialUrl { get; set; }

    public int? SocialPosition { get; set; }

    public bool? SocialStatus { get; set; }

    public string SocialClass { get; set; }
}
