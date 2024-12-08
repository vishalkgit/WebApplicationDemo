using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class Office
    {
        [Required(ErrorMessage ="Id is required")]
        [MaxLength(15)]
        [MinLength(2)]
       public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(35)]
        [MinLength(2)]
       public string? Name {  get; set; }

        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email {  get; set; }

        [Required(ErrorMessage ="Age is required")]
        [Range(minimum:20,maximum:60)]
        public int Age {  get; set; }

        [Required(ErrorMessage ="Depatrment name is required")]
        [MaxLength(35)]
        [MinLength(2)]
        public string? Dept {  get; set; }
        [Required(ErrorMessage ="Salary details are required")]
        public int Salary {  get; set; }

    }
}
