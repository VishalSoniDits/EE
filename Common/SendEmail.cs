using System;
using System.Net;
using System.Net.Mail;

namespace EE.Common
{
    public class SendEmail
    {
        public void SendEmails(string emailAddress, string bodyMessage, string subject, bool html)
        {
            try
            {
                MailMessage email = new MailMessage();
                email.From = new MailAddress("vishalsoniwins@gmail.com");
                email.To.Add(new MailAddress(emailAddress));
                email.Subject = subject;
                email.Body = bodyMessage;
                email.IsBodyHtml = html;

                SmtpClient smtpServer = new SmtpClient();
                smtpServer.Host = "smtp.gmail.com"; //AppSettingConfigurations.AppSettings.SmtpServer;
                smtpServer.Port = 587; //Convert.ToInt32(AppSettingConfigurations.AppSettings.SmtpPort);
                smtpServer.Credentials = new NetworkCredential("vishalsoniwins@gmail.com", "Techie@1234");
                //smtpServer.Credentials = new NetworkCredential(AppSettingConfigurations.AppSettings.SmtpUser, AppSettingConfigurations.AppSettings.SmtpPassword);
                smtpServer.EnableSsl = true; //Convert.ToBoolean(AppSettingConfigurations.AppSettings.SmtpSslEnabled);
                smtpServer.Send(email)
;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}