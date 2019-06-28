using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Service.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.Controllers
{
    [Route("[controller]/[action]")]
    public class Categories : Controller
    {
        

        private readonly ICategory category;

        public Categories(ICategory cat)
        {
            category = cat;
        }
        
        public IActionResult Cae()
        {

            var categor = category.GetAll().ToList();
            return View(categor);
        }
    }
}
