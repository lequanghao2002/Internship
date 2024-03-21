using MailKit.Net.Smtp;
using MimeKit;

namespace BNI.ultils
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Support BNI","SupporBNI@example.com")); // Điền thông tin email của bạn ở đây
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;

            var builder = new BodyBuilder();
            builder.TextBody = body;
            message.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false); // Thay thông tin SMTP server của bạn ở đây
                client.Authenticate("phu3365@gmail.com", "ykcyorhqndwvgabw"); // Điền thông tin đăng nhập email của bạn ở đây
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
