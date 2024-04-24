namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupHomeIntro
    {
        public string GroupHomeIntroTitleTop { get; set; }

        public string GroupHomeIntroTitle { get; set; }

        public string GroupHomeIntroText { get; set; }

        public string GroupHomeIntroButton { get; set; }

        public string GroupHomeIntroButtonUrl { get; set; }

        public List<GetGroupHomeIntroActivities> GroupHomeIntroActivities { get; set; } = [];

    }
}
