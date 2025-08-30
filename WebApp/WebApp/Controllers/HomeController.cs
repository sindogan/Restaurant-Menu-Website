

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApp.Models;
using WebApp.Repositories;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        KategoriRepository kategoriRepository = new KategoriRepository();
        List<Kategori> kategoriList = new List<Kategori>();
        kategoriList = kategoriRepository.Listele().ToList();
        ViewBag.KategoriListesi = kategoriList;

        UrunRepository urunRepository = new UrunRepository();
        List<Urun> urunList = new List<Urun>();
        urunList = urunRepository.Listele().ToList();
        ViewBag.UrunListesi = urunList;

        IletisimBilgileriRepository iletisimBilgileriRepository = new IletisimBilgileriRepository();
        List<IletisimBilgileri> iletisimBilgileriList = new List<IletisimBilgileri>();
        iletisimBilgileriList = iletisimBilgileriRepository.Listele().ToList();
        ViewBag.IletisimBilgileriListesi = iletisimBilgileriList;



        return View();
        

    }
    
        

    

    
}



