using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class UserViewModel
    {
        public class LoginUser
        {
            [Required(ErrorMessage="Email is required")]
            [EmailAddress(ErrorMessage="This is an email field")]
            [DataType(DataType.EmailAddress)]
            [Display(Name="Email")]
            public string Email {get;set;}

            [Required(ErrorMessage="Password is required")]
            [MinLength(4, ErrorMessage="A minimum length of 4")]
            [MaxLength(20, ErrorMessage="A maximum length of 20")]
            [DataType(DataType.Password)]
            [Display(Name="Password")]

            public string Password {get;set;}
        }
        public class RegisterUser
        {
            [Key]
            public int UserId {get;set;}

            [Required(ErrorMessage="First Name is required")]
            [MinLength(2, ErrorMessage="A minimum of 2 is allowed for first name")]
            [MaxLength(30, ErrorMessage="A maximum of 30 is allowed for first name")]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage="Your first name must only contain letters")]
            [Display(Name="First Name")]
            public string FirstName {get;set;}

            [Required(ErrorMessage="Last name is required")]
            [MinLength(2, ErrorMessage="A minimum of 2 is allowed for last name")]
            [MaxLength(30, ErrorMessage="A maximum of 30 is allowed for last name")]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage="Your last name must only contain letters")]
            [Display(Name="Last Name")]
            public string LastName {get;set;}

            [Required(ErrorMessage="Email is required")]
            [EmailAddress]
            [DataType(DataType.EmailAddress)]
            [Display(Name="Email")]
            public string Email {get;set;}

            [Required(ErrorMessage="Username is required")]
            [MinLength(2, ErrorMessage="A minimum of 2 is allowed for you username")]
            [MaxLength(30, ErrorMessage="A maximum of 30 is allowed for your username")]
            [Display(Name="Username")]
            public string Username {get;set;}

            [Required(ErrorMessage="Password is required")]
            [MinLength(4, ErrorMessage="A minimum length of 4")]
            [MaxLength(20, ErrorMessage="A maximum length of 20")]
            [DataType(DataType.Password)]
            [Display(Name="Password")]
            public string Password {get;set;}

            [Required(ErrorMessage="Confirm password is required")]
            [DataType(DataType.Password)]
            [Compare("password")]
            [Display(Name="Confirm Password")]
            public string Confirm {get;set;}
        }
    }
}