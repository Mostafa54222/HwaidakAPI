using HwaidakAPI.Models;

namespace HwaidakAPI.DTOs.Responses.Gyms
{
    public class GetGym
    {
        public int GymId { get; set; }

        public int? HotelId { get; set; }

        public string FacilityNameSys { get; set; }

        public string FacilityUrl { get; set; }

        public string FacilityPhoto { get; set; }

        public string FacilityBanner { get; set; }

        public bool? FacilityStatus { get; set; }

        public int GymContentId { get; set; }

        public int? LangId { get; set; }

        public bool? FacilityStatusLang { get; set; }

        public string FacilityName { get; set; }

        public string FacilitySummery { get; set; }

        public string MetatagTitle { get; set; }

        public string FacilityDetails { get; set; }

        public string MetatagDescription { get; set; }

        public string OpeningHours { get; set; }

        public string PersonalTrainer { get; set; }

        public string Fees { get; set; }

        public string AgeRequirement { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }
    }
}
