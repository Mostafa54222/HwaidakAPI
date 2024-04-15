namespace HwaidakAPI.DTOs.Responses.Gyms
{
    public class GetGymService
    {
        public int GymservicesId { get; set; }

        public string SpaservicesSys { get; set; }

        public int? SpaservicesPosition { get; set; }

        public int GymservicesContentId { get; set; }

        public string GymservicesName { get; set; }

        public int? LangId { get; set; }

        public string GymservicesDetails { get; set; }

        public string GymservicesExtraNote { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }

        public bool? SpaservicesStatus { get; set; }
    }
}
