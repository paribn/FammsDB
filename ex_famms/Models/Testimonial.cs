namespace ex_famms.Models
{
    public class Testimonial:BaseEntity
    {
        public string? Name { get; set; }
        public string? ImagePath { get; set; }

        public string? Position { get; set; }
        public string? Details { get; set; }
    }
}
