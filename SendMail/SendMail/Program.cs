using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace SendMail
{
    class Program
    {
        static void Main(string[] args)
        {            
            string SendersAddress = "batil.hasan19@gmail.com";          
            string ReceiversAddress = "monowar.mbstu@gmail.com";          
            const string SendersPassword = "00508028";    
            const string subject = "Testing"; 
            const string body = "Hi This Is my Mail From Gmail";

            try
            {
                //we will use Smtp client which allows us to send email using SMTP Protocol
                //i have specified the properties of SmtpClient smtp within{}
                //gmails smtp server name is smtp.gmail.com and port number is 587
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(SendersAddress, SendersPassword),
                    //Timeout = 3000
                };

                MailMessage message = new MailMessage(SendersAddress, ReceiversAddress, subject, body);
                Attachment attachment = new Attachment(@"C:\Users\Monowar\Desktop\aaa.txt");
                message.Attachments.Add(attachment);

                smtp.Send(message);  //send the mail
                Console.WriteLine("Message Sent Successfully");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
