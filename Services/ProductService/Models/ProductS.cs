using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProductService.Models
{
public class Product
{
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }
[Required]
[StringLength(100)]
public string ProductName { get; set; } = null!;
[StringLength(500)]
public string Description { get; set; } = null!;
[Column(TypeName = "decimal(18, 2)")]
public decimal Price { get; set; }
public int Quantity { get; set; }
}}