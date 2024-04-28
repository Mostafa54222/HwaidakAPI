using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGroupHomeIntroActivity
{
    public int GroupHomeIntroActivitiesId { get; set; }

    public int? GroupHomeIntroActivitiesNumber { get; set; }

    public string GroupHomeIntroActivitiesTextSys { get; set; }

    public bool? GroupHomeActivityStatus { get; set; }

    public int? GroupHomeActivityPosition { get; set; }

    public string GroupHomeIntroActivitiesQuantitySys { get; set; }

    public virtual ICollection<TblGroupHomeIntroActivitiesContent> TblGroupHomeIntroActivitiesContents { get; set; } = new List<TblGroupHomeIntroActivitiesContent>();
}
