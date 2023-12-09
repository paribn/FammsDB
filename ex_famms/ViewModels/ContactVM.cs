using System.ComponentModel.DataAnnotations;

namespace ex_famms.ViewModels
{
    public class ContactVM
    {
        [Required(ErrorMessage = "Full Name is required!")]
        [MinLength(3)]
        [MaxLength(50)]
        public string FullName { get; set; }


        [Required(ErrorMessage = "The email address is required!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject is required!")]
        [MaxLength(255)]

        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required!")]
        [MaxLength(255)]
        public string Message { get; set; }
    }
}
