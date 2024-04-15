using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblTeam
{
    public int TeamId { get; set; }

    public int? HotelId { get; set; }

    public string TeamNameSys { get; set; }

    public string TeamPhoto { get; set; }

    public int? TeamPosition { get; set; }

    public bool? TeamStatus { get; set; }

    public string TeamEmail { get; set; }

    public string TeamMobile { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool? IsMoreDetails { get; set; }

    public string TeamUrl { get; set; }

    public double? TeamPhotoWidth { get; set; }

    public double? TeamPhotoHieght { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual ICollection<TblTeamsContent> TblTeamsContents { get; set; } = new List<TblTeamsContent>();
}
