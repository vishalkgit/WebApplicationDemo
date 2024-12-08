using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class User
    {

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(30)]
        [MinLength(3)]
        public string? Username {  get; set; }

        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Age is required")]
        [Range(minimum:18, maximum:100)]
        public int Age { get; set; }


        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "password does not match")]

        public string? ConfirmPassword { get; set; }
    }
}
