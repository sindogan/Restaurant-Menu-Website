﻿//using Microsoft.AspNetCore.Mvc;
//using NuGet.Protocol.Core.Types;
//using WebApp.Models;
//using WebApp.Repositories;


//namespace WebApp.Controllers
//{
//    public class AdminHakkimizdaBilgileriController : Controller
//    {

      
//            public IActionResult Index()
//            {
               
//                HakkimizdaBilgileriRepository repository = new HakkimizdaBilgileriRepository();

//            List<HakkimizdaBilgileri> modelListesi = repository.Listele().Where(x => x.Durumu == 1).ToList();
             
//                ViewBag.HakkimizdaBilgileriList = modelListesi;

//                return View();
//            }


//        public IActionResult Guncelleme(int id)
//        {
//            HakkimizdaBilgileriRepository repository = new HakkimizdaBilgileriRepository();
//            HakkimizdaBilgileri hakkimizdaBilgileri = repository.Getir(id);

//            if (hakkimizdaBilgileri != null)
//            {
//                HttpContext.Session.SetObjectAsJson("HakkimizdaBilgileri", hakkimizdaBilgileri);
//            }
//            return RedirectToAction("Index", "AdminHakkimizdaBilgileriGuncelle");
//        }


//        public IActionResult Sil(int id)
//        {
//            HakkimizdaBilgileriRepository repository = new HakkimizdaBilgileriRepository();

//            HakkimizdaBilgileri hakkimizdaBilgileri = repository.Getir(id);

//            if (hakkimizdaBilgileri != null)
//            {
//                hakkimizdaBilgileri.Durumu = 0;
//                hakkimizdaBilgileri.GuncellenmeTarihi = DateTime.Now;
//                repository.Guncelle(hakkimizdaBilgileri);
//            }

//            return RedirectToAction("Index", "AdminHakkimizdaBilgileri");
//        }

//    }
//}
