using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblFaqQuestion
{
    public int QuestionId { get; set; }

    public int? SectionId { get; set; }

    public string Question { get; set; }

    public string Answer { get; set; }

    public int? LangId { get; set; }

    public bool? QuestionStatus { get; set; }

    public int? QuestionPosition { get; set; }

    public bool? IsDeletedQuestion { get; set; }

    public DateTime? DeletedDateQuestion { get; set; }

    public int? HotelId { get; set; }

    public virtual TblFaqSection Section { get; set; }
}
