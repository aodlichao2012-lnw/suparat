using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Service.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.Controllers
{
    public class Product : Controller
    {
        private readonly IProduct product;
        private readonly ICategory category;
       
        public Product(IProduct pro , ICategory cat)
        {
            product = pro;
            category = cat;
        }

        public IActionResult Index()
        {
            var products = product.GetAll().ToList();
            return View(products);
        }

        public IActionResult ProductDetail(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            return View(product.GetByid(Convert.ToInt32(id)));
        }
    }
}
