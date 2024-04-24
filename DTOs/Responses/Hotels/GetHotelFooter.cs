namespace HwaidakAPI.DTOs.Responses.Hotels
{
    public class GetHotelFooter
    {
        public string HotelEmail { get; set; }
        public string HotelPhone { get; set; }
        public string HotelAddress { get; set; }
        public string HotelLocationTitle { get; set; }
        public string HotelLocation { get; set; }
        public string GroupLogo { get; set; }
        public string Copyrights { get; set; }
        public List<GetHotelSocials> HotelSocials { get; set; } = [];
    }
}
