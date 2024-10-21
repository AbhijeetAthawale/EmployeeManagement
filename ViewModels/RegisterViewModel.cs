using System.ComponentModel.DataAnnotations;

namespace Employee_Management.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name Is Required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email Is Required")  ]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage ="Password Is Required")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8 , ErrorMessage = " The {0} must be at {2} at max {1} character long ")]
        [Compare("ConfirmPassword", ErrorMessage ="Password does not match")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }




    }
}
