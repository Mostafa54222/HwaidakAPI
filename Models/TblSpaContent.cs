using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSpaContent
{
    public int SpaContentId { get; set; }

    public int? SpaId { get; set; }

    public int? LangId { get; set; }

    public bool? FacilityStatusLang { get; set; }

    public string FacilityName { get; set; }

    public string FacilitySummery { get; set; }

    public string FacilityDetails { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public string OpeningHours { get; set; }

    public string CancellationPolicy { get; set; }

    public string SpaArrival { get; set; }

    public string AgeRequirement { get; set; }

    public virtual TblSpa Spa { get; set; }
}
