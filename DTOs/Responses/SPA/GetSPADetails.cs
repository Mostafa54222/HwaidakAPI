namespace HwaidakAPI.DTOs.Responses.SPA
{
    public class GetSPADetails
    {
        public string FacilityUrl { get; set; }

        public string FacilityPhoto { get; set; }

        public string FacilityBanner { get; set; }

        public string FacilityBannerTablet { get; set; }

        public string FacilityBannerMobile { get; set; }

        public string FacilityName { get; set; }

        public string FacilitySummery { get; set; }

        public string FacilityDetails { get; set; }




        public string OpeningHours { get; set; }

        public string CancellationPolicy { get; set; }

        public string SpaArrival { get; set; }

        public string AgeRequirement { get; set; }

        public string HotelUrl { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }

        public List<GetSPAGallery> SPAGallery { get; set; }
        public List<GetSPAService> SPAServices { get; set; }
    }
}
