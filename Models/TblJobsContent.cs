using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblJobsContent
{
    public int JobContentId { get; set; }

    public int? JobId { get; set; }

    public int? LangId { get; set; }

    public string JobCategory { get; set; }

    public string JobSchedule { get; set; }

    public string PositionType { get; set; }

    public string JobSummery { get; set; }

    public string JobDetails { get; set; }

    public virtual TblJob Job { get; set; }
}
