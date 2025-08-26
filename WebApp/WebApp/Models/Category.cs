using System.Collections.Generic;

public class TblCategory
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }

    public ICollection<TblProduct> Products { get; set; }
}
