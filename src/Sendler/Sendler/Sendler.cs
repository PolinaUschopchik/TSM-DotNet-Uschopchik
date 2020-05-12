using System;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
namespace Sendler
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello in the mail sendler");
            Menu();

        }

        static void Menu()
        {
            MenuText();
            var input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "w":
                    MailSend();
                    break;

                case "e":
                    break;

                default:
                    break;
            }
        }

        static void MenuText()
        {
            Console.WriteLine("\t\t\tMenu");
            Console.WriteLine("Choose what you want");
            Console.WriteLine("\tw – write and send a message");
            Console.WriteLine("\te – exit");
        }

        static void MailSend()
        {
            Console.WriteLine("Enter your mail");
            string FromMail = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter subject");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter message");
            string message = Console.ReadLine();
            Console.WriteLine("Enter to mail");
            string ToMail = Console.ReadLine();

            Task task = new Task(() => SendMail(FromMail, password, subject, message, ToMail));
            task.Start();
        }
        
        public async Task SendMail(string FromMail, string password, string subject, string message, string ToMail)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(FromMail));
            emailMessage.To.Add(new MailboxAddress(ToMail));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("Plain")
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync(FromMail, password);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
            
        }

    }

}
