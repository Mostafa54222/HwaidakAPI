namespace HwaidakAPI.DTOs.Responses.Group
{
    public class GetGroupFooter
    {
        public string GroupAddress { get; set; }

        public string GroupMail { get; set; }

        public string GroupPhone { get; set; }

        public string GroupSummery { get; set; }

        public string GroupLogo { get; set; }
        public string Copyrights { get; set; }

        public List<GetGroupSocials> GroupSocials { get; set; } = [];
    }
}
