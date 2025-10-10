using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class Product
{
    [Key]
    public int PId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public long Price { get; set; }
    public required string PictureUrl { get; set; }
    public required string ProductType { get; set; }
    public required string ProductBrand { get; set; }
    public int QuantityInStock { get; set; }
}
