using System;
using System.IO;
using System.Net.Mail;
using Mcba.Infraestruture.Settings;

namespace Mcba.Infraestruture.Helpers
{
    public static class MailHelper
    {
        public static bool SendMail(string email, string subject, string body)
        {
            try
            {
                using (MailMessage message = new MailMessage())
                {
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        message.From = new MailAddress(McbaSettings.EmailFrom);
                        message.To.Add(new MailAddress(email));
                        message.Subject = subject;
                        message.IsBodyHtml = false;
                        message.Body = body;
                        smtp.Port = 465; //McbaSettings.EmailPort;
                        smtp.Host = McbaSettings.EmailHost;
                        smtp.EnableSsl = McbaSettings.EmailSsl;
                        smtp.UseDefaultCredentials = true;
                        //smtp.Credentials = new NetworkCredential(McbaSettings.EmailFrom, McbaSettings.EmailPass);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);

                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static void SaveToFile(string email, string subject, string body)
        {
            string[] lines =
            {
                email, subject, body
            };

            var fileName = Guid.NewGuid().ToString();

            if (!Directory.Exists(McbaSettings.TempFolder))
            {
                Directory.CreateDirectory(McbaSettings.TempFolder);
            }

            File.WriteAllLines($"{Path.Combine(McbaSettings.TempFolder, fileName)}.txt", lines);
        }
    }
}