using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;



namespace LiftIt.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                //From Address    
                string FromAddress = "liftit2018@gmail.com";
                string FromAdressTitle = "Lift-It";
                //To Address    
                string ToAddress = email;
                string ToAdressTitle = "Microsoft ASP.NET Core";
                string Subject = subject;
                string BodyContent = message;

                //Smtp Server    
                string SmtpServer = "smtp.gmail.com";
                //Smtp Port Number    
                int SmtpPortNumber = 587;

                BodyBuilder bodyBuilder = new BodyBuilder();

               // bodyBuilder.TextBody

                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress
                                        (FromAdressTitle,
                                         FromAddress
                                         ));
                mimeMessage.To.Add(new MailboxAddress
                                         (ToAdressTitle,
                                         ToAddress
                                         ));
                mimeMessage.Subject = Subject; //Subject  
                mimeMessage.Body = new TextPart("html")
                {
                    Text = BodyContent
                };


                using (var client = new SmtpClient())
                {
                    client.Connect(SmtpServer, SmtpPortNumber, false);
                    client.Authenticate(
                        "liftit2018@gmail.com",
                        "Student12#"
                        );
                    await client.SendAsync(mimeMessage);
                    Console.WriteLine("The mail has been sent successfully !!");
                    //Console.ReadLine();
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
