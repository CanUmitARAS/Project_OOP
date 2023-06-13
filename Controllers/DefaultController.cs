using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Project_OOP.examp;

namespace Project_OOP.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Kullanıcı("Tonguc");
            return View();

        }

        public IActionResult Musteriler()
        {
            Kullanıcı("Tonguc1");
            return View();

        }

        public IActionResult Urunler()
        {
            Kullanıcı("Tonguc2");
            return View();
        }


        public void Kullanıcı(string kullanici)
        {
            ViewBag.m1 = kullanici;
        }

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();



            sehirler.Ad = "kiev";
            sehirler.SehirId = 1;
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.renk1 = "sarı";
            sehirler.renk2 = "mavi";

            sehirler.Ad = "Tiflis";
            sehirler.SehirId = 2;
            sehirler.Nufus = 200;
            sehirler.Ulke = "Gürcistan";

            ViewBag.V1 = sehirler.Ad;
            ViewBag.V2 = sehirler.SehirId;
            ViewBag.V3 = sehirler.Nufus;
            ViewBag.V4 = sehirler.Ulke;
            ViewBag.v5 = sehirler.renk1;
            ViewBag.v6 = sehirler.renk2;
            ViewBag.v7 = sehirler.renk3;


            return View();
        }





    }
}
