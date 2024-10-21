using System.ComponentModel.DataAnnotations;

namespace Employee_Management.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
