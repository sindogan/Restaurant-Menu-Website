

public class MenuViewModel
{
    public int CategoryId { get; set; }
    public required string CategoryName { get; set; }
    public required List<ProductViewModel> Products { get; set; }
}

public class ProductViewModel
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
}
