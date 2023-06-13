using Microsoft.AspNetCore.Mvc;
using Project_OOP.Entity;
using Project_OOP.ProjectContext;
using System.Linq;

namespace Project_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult Index()
        {
            var values = context.customers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer(int p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = context.customers.Where(x => x.CustomerId == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.customers.Where(x => x.CustomerId == id).FirstOrDefault();
            return View(value);

        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.customers.Where(x => x.CustomerId == p.CustomerId).FirstOrDefault();

            value.CustomerCity = p.CustomerCity;
            value.CustomerName = p.CustomerName;
            context.SaveChanges();

            return RedirectToAction("Index");

        }





    }
}
