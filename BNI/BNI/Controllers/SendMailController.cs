using BNI.ultils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Fpe;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMailController : ControllerBase
    {
        private readonly EmailService _emailService;

        public SendMailController(EmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost("send")]
        public IActionResult SendEmail(string to, string subject, string body)
        {
            _emailService.SendEmail(to, subject, body);
            return Ok("Email sent successfully!");
        }
    }
}
