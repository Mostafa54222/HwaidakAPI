using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeIntroActivity
{
    public int GroupHomeIntroActivitiesId { get; set; }

    public string GroupHomeIntroActivitiesNumber { get; set; }

    public string GroupHomeIntroActivitiesTextSys { get; set; }

    public bool? GroupHomeActivityStatus { get; set; }

    public int? GroupHomeActivityPosition { get; set; }
}
