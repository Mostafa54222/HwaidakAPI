using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblJob
{
    public int JobId { get; set; }

    public string JobNameSys { get; set; }

    public DateTime? PostingDate { get; set; }

    public string JobNumber { get; set; }

    public string JobUrl { get; set; }

    public bool? IsActive { get; set; }

    public int? HotelId { get; set; }

    public virtual ICollection<TblJobsContent> TblJobsContents { get; set; } = new List<TblJobsContent>();
}
