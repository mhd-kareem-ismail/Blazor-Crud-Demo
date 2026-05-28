using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    /// <summary>
    /// Represents a product in our in-memory store.
    /// Uses Data Annotations for built-in Blazor form validation.
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10000.00.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(0, 1000, ErrorMessage = "Quantity must be between 0 and 1000.")]
        public int Quantity { get; set; }
    }
}
