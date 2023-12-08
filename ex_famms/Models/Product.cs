namespace ex_famms.Models
{
    public class Product :BaseEntity
    {
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public decimal? Price { get; set; }


    }
}
