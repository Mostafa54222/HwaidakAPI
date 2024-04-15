using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGymContent
{
    public int GymContentId { get; set; }

    public int? GymId { get; set; }

    public int? LangId { get; set; }

    public bool? FacilityStatusLang { get; set; }

    public string FacilityName { get; set; }

    public string FacilitySummery { get; set; }

    public string FacilityDetails { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public string OpeningHours { get; set; }

    public string PersonalTrainer { get; set; }

    public string Fees { get; set; }

    public string AgeRequirement { get; set; }

    public virtual TblGym Gym { get; set; }
}
