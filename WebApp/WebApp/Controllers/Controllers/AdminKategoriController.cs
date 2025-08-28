//using Microsoft.AspNetCore.Mvc;
//using WebApp.Models;
//using WebApp.Repositories;

//namespace WepApp.Controllers
//{
//    public class AdminKategoriController : Controller
//    {
//        public IActionResult Index()
//        {
//            CategoryRepository categoryRepository = new CategoryRepository();
          
//            List<Category> list = new List<Category>();
            
//            ViewBag.Category = list;
            
//            return View();
//        }
//        //public IActionResult Guncelleme(int id)
//        //{
//        //    CategoryRepository repository = new CategoryRepository();
//        //    Category urun = repository.Getir(id);
//        //    if (urun == null)
//        //    {
//        //        return RedirectToAction("Index", "AdminKategoriGuncelle");
//        //    }
//        //    HttpContext.Session.SetObjectAsJson("Category", urun);
//        //    return RedirectToAction("Index", "AdminKategoriGuncelle");
//        //}
//        public IActionResult Sil(int id)
//        {
//         CategoryRepository repository = new CategoryRepository();
//            Category urun = repository.Getir(id);
//            if (urun != null)
//            {
//                urun.CategoryName = "";
//                urun.CategoryDescription = "";
//                repository.Guncelle(urun);
//            }
//            return RedirectToAction("Index", "AdminKategori");
//        }

//    }
//}
