using HwaidakAPI.DTOs.Responses.News;

namespace HwaidakAPI.DTOs.Responses.Home
{
    public class GetWholeHomePage
    {
        public List<GetSliders> Sliders { get; set; }
        public List<GetSiteContacts> SiteContacts { get; set; }
        public List<GetSiteSocials> SiteSocials { get; set; }
        public List<GetNewsList> News { get; set; }
        public List<GetHotelHome> Hotels { get; set; }


    }
}
