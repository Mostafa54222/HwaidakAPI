namespace HwaidakAPI.DTOs.Responses.Home
{
    public class GetSliders
    {
        public int SliderId { get; set; }


        public int? LangId { get; set; }


        public int? SliderPosition { get; set; }

        public string SliderPhoto { get; set; }

        public string SliderMainText { get; set; }

        public string SliderSubText { get; set; }

        public string SliderButtonText { get; set; }

        public string SliderbuttonUrl { get; set; }


        public bool? IsDisplayContent { get; set; }



        public int? HotelId { get; set; }
    }
}
