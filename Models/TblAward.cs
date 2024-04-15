using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblAward
{
    public int Awardid { get; set; }

    public int? AwardYear { get; set; }

    public string Awardphoto { get; set; }

    public int? Awardposition { get; set; }

    public bool? Awardstatus { get; set; }

    public int? HotelId { get; set; }

    public string Awardtitlesys { get; set; }

    public string ExternalLink { get; set; }

    public DateTime? AwardDate { get; set; }

    public int? AwardYearCategorId { get; set; }

    public int? RoomPhotoWidth { get; set; }

    public int? RoomPhotoHieght { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual ICollection<TblAwardsContent> TblAwardsContents { get; set; } = new List<TblAwardsContent>();
}
