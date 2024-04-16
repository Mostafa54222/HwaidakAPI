namespace HwaidakAPI.DTOs.Responses.SPA
{
    public class GetSPAService
    {
        public int SpaservicesId { get; set; }

        public int? SpaservicesPosition { get; set; }

        public bool? SpaservicesStatus { get; set; }

        public int SpaservicesContentId { get; set; }

        public string SpaservicesName { get; set; }

        public int? LangId { get; set; }

        public string SpaservicesDetails { get; set; }

        public string SpaservicesTime { get; set; }

        public string SpaservicesPrice { get; set; }

        public string SpaservicesExtraNote { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }

        public int? SpaservicesTypeId { get; set; }

        public string SpaservicesTypeName { get; set; }

        public int? SpaservicesTypePosition { get; set; }

        public int? SpaId { get; set; }

        public int? HotelId { get; set; }

        public string FacilityUrl { get; set; }
    }
}
