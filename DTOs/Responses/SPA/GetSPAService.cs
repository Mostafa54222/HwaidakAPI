namespace HwaidakAPI.DTOs.Responses.SPA
{
    public class GetSPAService
    {

        public int? SpaservicesPosition { get; set; }

        public int SpaservicesContentId { get; set; }

        public string SpaservicesName { get; set; }

        public int? LangId { get; set; }

        public string SpaservicesDetails { get; set; }

        public string SpaservicesTime { get; set; }

        public string SpaservicesPrice { get; set; }

        public string SpaservicesExtraNote { get; set; }

        public string LanguageAbbreviation { get; set; }

        public int? SpaservicesTypeId { get; set; }

        public string SpaservicesTypeName { get; set; }

        public int? SpaservicesTypePosition { get; set; }

        public string FacilityUrl { get; set; }
    }
}
