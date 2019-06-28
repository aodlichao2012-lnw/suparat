using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;
using Ecom.ViewModel.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.Controllers
{
    public class Account : Controller
    {
        private readonly UserManager<Customer> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly SignInManager<Customer> signInManager;

        public Account(UserManager<Customer> manager,RoleManager<ApplicationRole> role, SignInManager<Customer> sign)
        {
            userManager = manager;
            roleManager = role;
            signInManager = sign;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if(ModelState.IsValid)
            {
                var customer = new Customer { UserName = registerVM.Email, Email = registerVM.Email };
              
                var Result = await userManager.CreateAsync(customer, registerVM.Password);

                if(Result.Succeeded)
                {
                    if(!roleManager.RoleExistsAsync("SiteUser").Result)
                    {
                        ApplicationRole role = new ApplicationRole();
                        role.Name = "SiteUser";

                        IdentityResult roleResult = roleManager.CreateAsync(role).Result;

                        if(!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "บางอย่างผิดพลาดหรือท่านกรอกผิด");
                            return View(registerVM);
                        }
                    }
                    userManager.AddToRoleAsync(customer, "SiteUser").Wait();
                    await signInManager.SignInAsync(customer, isPersistent: false);
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(registerVM);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost , ValidateAntiForgeryToken]
        public IActionResult Login(LoginVM loginVM)
        {
            if(ModelState.IsValid)
            {
                var Resul = signInManager.PasswordSignInAsync
                    (
                    loginVM.Email,
                    loginVM.Password,
                    loginVM.RememberMe,
                    false
                    ).Result;
                if(Resul.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "มีบางอย่างผิดปกติหรือท่านกรอกผิด !!");
                }

            }
            return View(loginVM);

        }

        [HttpPost , ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
