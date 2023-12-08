using System.ComponentModel.DataAnnotations;

namespace ex_famms.ViewModels
{
    public class ContactVM
    {
        [MinLength(3)]
        [MaxLength(50)]
        public string FullName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]

        public string Subject { get; set; }

        [Required]
        [MaxLength(255)]
        public string Message { get; set; }
    }
}
