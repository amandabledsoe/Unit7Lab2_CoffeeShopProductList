using System.ComponentModel.DataAnnotations;

namespace U7L2.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
