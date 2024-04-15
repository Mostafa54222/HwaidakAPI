using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHomeWhyU
{
    public int WhuUsId { get; set; }

    public string WhuUsTitleSys { get; set; }

    public int? WhuUsPosition { get; set; }

    public string WhuUsPhoto { get; set; }

    public bool? WhuUsStatus { get; set; }

    public string WhyChooseUsclass { get; set; }

    public int? HotelId { get; set; }

    public virtual ICollection<TblHomeWhyUsContent> TblHomeWhyUsContents { get; set; } = new List<TblHomeWhyUsContent>();
}
