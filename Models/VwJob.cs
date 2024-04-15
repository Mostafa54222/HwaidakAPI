using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwJob
{
    public int JobId { get; set; }

    public string JobNameSys { get; set; }

    public DateTime? PostingDate { get; set; }

    public string JobNumber { get; set; }

    public string JobUrl { get; set; }

    public bool? IsActive { get; set; }

    public int? HotelId { get; set; }

    public int JobContentId { get; set; }

    public int? LangId { get; set; }

    public string JobCategory { get; set; }

    public string JobSchedule { get; set; }

    public string PositionType { get; set; }

    public string JobSummery { get; set; }

    public string JobDetails { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }
}
