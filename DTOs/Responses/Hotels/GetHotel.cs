namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetHotel
    {
        public int HotelId { get; set; }

        public string HotelNameSys { get; set; }

        public string HotelUrl { get; set; }
        public string HotelPmscode { get; set; }

        public string HotelPhoto { get; set; }

        public string HotelLogo { get; set; }

        public bool? HotelStatus { get; set; }

        public int? CountryId { get; set; }

        public int? DestinationId { get; set; }

        public string HotelEmail { get; set; }

        public GetHotelContent HotelContent { get; set; }
        public List<GetHotelGallery> HotelGallery { get; set; }

    }
}
