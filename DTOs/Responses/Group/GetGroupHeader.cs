using HwaidakAPI.DTOs.Responses.Home;

namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupHeader
    {
        public string GroupPhone { get; set; }
        public string GroupLogo { get; set; }
        public List<LanguageResponse> Languages { get; set; } = [];
    }
}
