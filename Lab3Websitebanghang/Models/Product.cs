using System.ComponentModel.DataAnnotations;

namespace Lab3Websitebanghang.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public required string Name { get; set; }

        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }
        [Required, StringLength(100)]
        public required string Description { get; set; }
        [Required]
        public required string ImageUrl { get; set; }
        public List<ProductImage>? Image { get; set;}
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }

}
