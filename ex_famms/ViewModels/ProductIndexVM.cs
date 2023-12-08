using ex_famms.Models;

namespace ex_famms.ViewModels
{
    public class ProductIndexVM
    {
        public List<Product> Products { get; set; }

        public List<Testimonial> Testimonials { get; set; }
        public List<Contact>? ContactFooter { get; set; }
    }
}
