using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Dbcontext;
using Ecom.Models;
using Ecom.Paypal;
using Ecom.Service.Infrastructure;
using Ecom.ViewModel.Card;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.Controllers
{
    public class Card : Controller
    {
        private readonly DBcontext context;
        private readonly UserManager<Customer> userManager;
        private readonly ICartItem cartItem ;
        private PaypalSettings configsetting { get; set; }

        public Card(UserManager<Customer> Manager, ICartItem  cart ,IOptions<PaypalSettings> settings , DBcontext bcontext)
        {
            context = bcontext;
            userManager = Manager;
            cartItem = cart;
            configsetting = settings.Value;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var query = from p in context.cartItems
                        where p.CustomerID == userid
                        group p by new { p.Product.ProductName, p.Product.UnitPrice } into g
                        select new
                        {
                            Nane = g.Key.ProductName,
                            Count = g.Count(),
                            Price = g.Key.UnitPrice
                        };
            CardIndexVM CardVM = new CardIndexVM();
            foreach(var item in query)
            {
                CardProductVM cProduct = new CardProductVM();
                cProduct.ProductName = item.Nane;
                cProduct.Quantity = item.Count;
                cProduct.Price = item.Price;
                cProduct.ProductTotal = item.Price * item.Count;

                CardVM.CardProductVMList.Add(cProduct);
            }
            CardVM.CardTotalPrice = CardVM.CardProductVMList.Sum(p => p.ProductTotal);
            return View(CardVM);
        }

        [HttpPost]
        public IActionResult Add([FromForm] int? id)
        {
            if(id != null)
            {
                var userid = userManager.GetUserId(HttpContext.User);
                CartItem cartItem = new CartItem()
                {
                    CustomerID = userid,
                    AddDate = DateTime.Now,
                    ProductID = Convert.ToInt32(id)
                };
                context.cartItems.Add(cartItem);
                context.SaveChanges();
            }
            else
            {
                ModelState.AddModelError("", "Something went wrong");
            }
            return View("Index", "Product");
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        public IActionResult Return()
        {
            return Content(Request.QueryString.ToString());
        }
        public IActionResult Cancel()
        {
            return Content(Request.QueryString.ToString());
        }
        public IActionResult Pay(PaypalOrder order)
        {
            PaypalRedirect redirect = PaypalLogic.ExpressCheckout (order);
            HttpContext.Session.SetString("Token", redirect.Token);
            return new RedirectResult(redirect.Url);
        }
    }
}
