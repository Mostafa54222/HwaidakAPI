namespace HwaidakAPI.DTOs.Responses.Facilities
{
    public class GetFacilityDetails
    {
        public string FacilityName { get; set; }

        public string FacilityPhoto { get; set; }

        public string FacilityUrl { get; set; }
        public string FacilityBanner { get; set; }

        public string FacilityBannerTablet { get; set; }

        public string FacilityBannerMobile { get; set; }

        public string FacilitySummery { get; set; }

        public string FacilityDetails { get; set; }

        public string MetatagTitle { get; set; }

        public string MetatagDescription { get; set; }

      
        public bool? IsMoreDetails { get; set; }

        public string HotelUrl { get; set; }

        public List<GetFacilityGallery> FacilityGallery { get; set; }
        public List<GetFacility> OtherFacility { get; set; }

    }
}
