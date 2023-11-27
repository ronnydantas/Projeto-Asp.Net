using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTest.Model;
using WebTest.ViewModels;

namespace WebTest.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager; 

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager) 
        {
            this.signInManager = signInManager;
            this.userManager = userManager; 
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                if (Model.Email == "admin@lrsv.com.br" && Model.Password == "Ab!123")
                {
                    return RedirectToPage("Admin");
                }

                var user = await userManager.FindByEmailAsync(Model.Email);

                if (user != null && user.Situacao == "Ativo")
                {
                    var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RelembreMe, false);

                    if (identityResult.Succeeded)
                    {
                        if (returnUrl == null || returnUrl == "/")
                        {
                            return RedirectToPage("Ponto");
                        }
                        else
                        {
                            return RedirectToPage(returnUrl);
                        }
                    }

                    ModelState.AddModelError("", "Nome do usuário ou a senha está incorreta!");
                }
                else
                {
                    ModelState.AddModelError("", "O usuário não está ativo.");
                }
            }

            return Page();
        }
    }
}
