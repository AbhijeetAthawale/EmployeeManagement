using System.ComponentModel.DataAnnotations;

namespace Employee_Management.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = " Password Is Required ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe
        {
            get; set;

        }
    }
}
