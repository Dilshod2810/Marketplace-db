namespace Domain.Models;

public class Products
{
    public int Id { get; set; }
    public required string ProductName { get; set; }
    public decimal Price { get; set; }
    public int MarketId { get; set; }
    public int CategoryId { get; set; }
}

