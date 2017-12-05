using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendMailSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = "<h1>This is a header</h2><p>This is a test <strong>with strong</strong></p>";

            using(var client = new SmtpClient())
            {
                var message = new MailMessage()
                {
                    IsBodyHtml = true,
                    Body = content,
                    Subject = "Test mail"
                };

                message.To.Add("contact@alantsai.net");

                client.Send(message);
            }
        }
    }
}
