using System.Net.Mail;
using System.Net;

namespace HwaidakAPI.Helpers
{
    public class EmailSender : IEmailSender
    {
        public void SendMail(string fromAddress, string toAddress, string mailSubject, string mailBody)
        {

            MailMessage mail = new MailMessage();
            MailMessage mailMsg = new MailMessage(fromAddress, toAddress, mailSubject, mailBody);
            mailMsg.IsBodyHtml = true;
            mailMsg.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();

            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("do_not_reply@cleoparksharm.com", "0C27xy@5i_1Coy56q1");
            smtp.Host = "red.specialservers.com";
            smtp.Port = 587;

            smtp.Send(mailMsg);

        }
    }
}
