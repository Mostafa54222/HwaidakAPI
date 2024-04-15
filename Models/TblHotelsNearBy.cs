using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHotelsNearBy
{
    public int HotelNearById { get; set; }

    public int? HotelId { get; set; }

    public string HotelNearByNameSys { get; set; }

    public bool? HotelNearByStatus { get; set; }

    public double? HotelNearByDistance { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual ICollection<TblHotelsNearByContent> TblHotelsNearByContents { get; set; } = new List<TblHotelsNearByContent>();
}
