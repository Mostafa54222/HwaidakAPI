namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetHotelGallery
    {
        public int GallerySectionId { get; set; }

        public bool? GalleryStatus { get; set; }

        public int? GalleryPosition { get; set; }

        public int GallerySectionContentId { get; set; }

        public int LangId { get; set; }

        public string GallerySectionName { get; set; }

        public string LanguageName { get; set; }

        public string LanguageFlag { get; set; }

        public string LanguageAbbreviation { get; set; }

        public int? HotelId { get; set; }

        public string HotelUrl { get; set; }

        public string HotelNameSys { get; set; }
    }
}
