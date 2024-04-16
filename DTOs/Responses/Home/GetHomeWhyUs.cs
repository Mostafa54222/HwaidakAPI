namespace HwaidakAPI.DTOs.Responses.Home
{
    public class GetHomeWhyUs
    {
        public int WhuUsId { get; set; }

        public string WhuUsTitleSys { get; set; }

        public int? WhuUsPosition { get; set; }

        public string WhuUsPhoto { get; set; }

        public bool? WhuUsStatus { get; set; }

        public int WhuUsContentId { get; set; }

        public int? LangId { get; set; }

        public string WhuUsTitle { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }

        public string WhyChooseUsclass { get; set; }

        public string WhuUsText { get; set; }

        public int? HotelId { get; set; }
    }
}
