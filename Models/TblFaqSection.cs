using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblFaqSection
{
    public int FaqsectionId { get; set; }

    public string SectionName { get; set; }

    public int? LangId { get; set; }

    public bool? SectionStatus { get; set; }

    public int? SectionPosition { get; set; }

    public int? HotelId { get; set; }

    public virtual ICollection<TblFaqQuestion> TblFaqQuestions { get; set; } = new List<TblFaqQuestion>();
}
