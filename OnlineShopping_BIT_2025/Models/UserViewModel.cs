using System.ComponentModel.DataAnnotations;

namespace OnlineShopping_BIT_2025.Models
{
    public class UserViewModel
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "email is invalid")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password length should be greater than5")]

        public string Password { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password length should be greater than5")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }
    }
}
