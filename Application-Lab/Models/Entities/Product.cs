using System.ComponentModel.DataAnnotations;

namespace Application_Lab.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100)]

        public string Name { get; set; }
        [Required, Range(1, 10000)]
        public decimal Price { get; set; }
        [StringLength(200)]

        public string? Description { get; set; }
    }
}
