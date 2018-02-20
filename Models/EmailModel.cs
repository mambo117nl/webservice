using System;
using System.ComponentModel.DataAnnotations;

namespace web_api.Models {
  public class EmailModel {
    [Required]
    [MinLength (5)]
    [EmailAddress]
    public string Sender { get; set; }

    [Required]
    public string SenderPassword { get; set; }

    [Required]
    [MinLength (3, ErrorMessage = "Invalid Recipient")]
    [EmailAddress]
    public string Recipient { get; set; }

    [Required]
    [MinLength (10)]
    public string Message { get; set; }

    [Required]
    [MinLength (3)]
    public string Subject { get; set; }

    [Required]
    [MinLength (3)]
    public string Name { get; set; }
  }
}
