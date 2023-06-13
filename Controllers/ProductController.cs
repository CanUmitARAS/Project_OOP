using Microsoft.AspNetCore.Mvc;
using Project_OOP.Entity;
using Project_OOP.ProjectContext;
using System.Linq;

namespace Project_OOP.Controllers
{
    public class ProductController : Controller
    {

        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.products.ToList();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = context.products.Where(x => x.ProductID == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateProduct(int id)
        {
            var value = context.products.Where(x => x.ProductID == id).FirstOrDefault();
            return View(value);

        }

        public IActionResult UpdateProduct(Product p)
        {
            var value = context.products.Where(x => x.ProductID == p.ProductID).FirstOrDefault();
            value.ProductName = p.ProductName;
            value.Price = p.Price;
            value.Stock = p.Stock;
            context.SaveChanges();


            return RedirectToAction("Index");
        }


    }
}
