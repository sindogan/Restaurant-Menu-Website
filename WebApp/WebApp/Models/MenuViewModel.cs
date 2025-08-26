

public class MenuViewModel
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<ProductViewModel> Products { get; set; }
}

public class ProductViewModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
}
