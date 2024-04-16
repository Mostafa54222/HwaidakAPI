using HwaidakAPI.DTOs.Responses.Rooms;

namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetHotelFacilities
    {
        public int FacilitiesPerHotelId { get; set; }

        public int? HotelId { get; set; }

        public int? HotelFacilitiesItemId { get; set; }

        public string HotelNameSys { get; set; }

        public string HotelUrl { get; set; }

        public string HotelFacilitiesItemName { get; set; }

        public string HotelFacilitiesItemExtraText { get; set; }

        public int? HotelFacilitiesItemPosition { get; set; }

        public bool? HotelFacilitiesItemStatus { get; set; }

        public int HotelFacilitiesId { get; set; }

        public string HotelFacilitiesIcon { get; set; }

        public int? HotelFacilitiesPoisition { get; set; }

        public bool? HotelFacilitiesStatus { get; set; }

        public int? LangId { get; set; }

        public string HotelFacilitiesName { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }

        public bool? LangStatus { get; set; }

        public int HotelFacilitiesItemContentId { get; set; }

    }
}
