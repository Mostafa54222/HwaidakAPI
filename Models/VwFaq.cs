using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwFaq
{
    public int FaqsectionId { get; set; }

    public string SectionName { get; set; }

    public int? LangId { get; set; }

    public bool? SectionStatus { get; set; }

    public int? SectionPosition { get; set; }

    public int QuestionId { get; set; }

    public string Question { get; set; }

    public string Answer { get; set; }

    public bool? QuestionStatus { get; set; }

    public int? QuestionPosition { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public bool? IsDeletedQuestion { get; set; }

    public DateTime? DeletedDateQuestion { get; set; }

    public int? HotelId { get; set; }
}
