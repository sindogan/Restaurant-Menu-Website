
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

//using System.Linq;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//  // Veritabanı bağlamınızın olduğu alan adını değiştirin
//// ViewModel'lerinizin olduğu alan adını değiştirin

//public class HomeController : Controller
//{
//    private readonly AppDbContext _context; // Veritabanı bağlamınızın adını değiştirin

//    public HomeController(AppDbContext context)
//    {
//        _context = context;
//    }

//    public IActionResult Index()
//    {
//        // İşletme bilgilerini al
//        var business = _context.TblBusiness
//            .Include(b => b.Address) // Adresleri dahil et
//            .Include(b => b.Socials) // Sosyal medya bağlantılarını dahil et
//            .Include(b => b.Menus)
//            .ThenInclude(m => m.Categories)
//            .ThenInclude(c => c.Products)
//            .FirstOrDefault();

//        if (business == null)
//        {
//            return NotFound(); // İşletme bilgisi bulunamazsa 404 döndür
//        }

//        // Adresleri ve sosyal medya bağlantılarını ViewBag'e at
//        ViewBag.Addresses = business.Address.ToList();
//        ViewBag.Socials = business.Socials.ToList();

//        // Menü verilerini ViewModel'e dönüştür
//        var menuViewModels = business.Menus
//            .SelectMany(m => m.Categories)
//            .Select(c => new MenuViewModel
//            {
//                CategoryId = c.CategoryId,
//                CategoryName = c.CategoryName,
//                Products = c.Products.Select(p => new ProductViewModel
//                {
//                    ProductId = p.ProductId,
//                    ProductName = p.ProductName,
//                    Description = p.Description,
//                    Price = p.Price,
//                    ImageUrl = p.ImageUrl
//                }).ToList()
//            }).ToList();

//        // Sadece menü verilerini View'a gönder
//        return View(menuViewModels);
//    }
//}
