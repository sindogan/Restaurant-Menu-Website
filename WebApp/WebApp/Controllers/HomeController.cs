//using Microsoft.AspNetCore.Mvc;

//public class HomeController : Controller
//{
//    private readonly AppDbContext _context;

//    public HomeController(AppDbContext context)
//    {
//        _context = context;
//    }

//    public IActionResult Index()
//    {
//        var menuItems = _context.TblProduct.ToList();
//        ViewBag.Products = menuItems;
//        return View();
//    }
//}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var categories = _context.TblCategory
            .Include(c => c.Products)
            .Select(c => new MenuViewModel
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                Products = c.Products.Select(p => new ProductViewModel
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl
                }).ToList()
            }).ToList();

        return View(categories);
    }
}
