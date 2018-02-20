using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_api.Models;

namespace web_api.Controllers {
  public class EmailController : Controller {

    [HttpPost ("api/send")]
    public async Task<IActionResult> Send ([FromBody] EmailModel email) {
      if (!ModelState.IsValid) {
        return BadRequest ("Invalid email properties.");
      }

      MailAddress from = new MailAddress (email.Sender);
      MailMessage message = new MailMessage ();
      MailAddress recipient = new MailAddress (email.Recipient);
      SmtpClient _smtp = new SmtpClient ("smtp.live.com", 587);
      _smtp.UseDefaultCredentials = false;
      _smtp.Timeout = 10000;
      _smtp.EnableSsl = true;
      _smtp.Credentials = new System.Net.NetworkCredential (email.Sender, email.SenderPassword);

      message = new MailMessage (from, recipient);
      message.Subject = email.Subject;
      message.Body = email.Message;

      await _smtp.SendMailAsync (message);

      return Ok ();
    }
  }
}
