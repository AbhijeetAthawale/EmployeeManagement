using System.ComponentModel.DataAnnotations;

namespace Employee_Management.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage = " The {0} must be at {2} at max {1} character long ")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Confirm Password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm New Password Is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string ConfirmNewPassword { get; set; }
    }
}
