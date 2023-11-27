using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Model;

namespace WebTest.Pages
{
    public class BeneficiosModel : PageModel
    {
        private readonly AuthDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;


        [BindProperty]
        public string Cpf { get; set; }

        [BindProperty]
        public int Va { get; set; }

        [BindProperty]
        public int Vt { get; set; }

        [BindProperty]
        public int Vr { get; set; }
        public string NomeUsuario { get; set; }

        public BeneficiosModel(AuthDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    var beneficio = new Beneficios
                    {
                        Va = Va,
                        Vt = Vt,
                        Vr = Vr,
                        NomeUsuario = user.Nome
                    };

                    user.Beneficios.Add(beneficio);
                    await _userManager.UpdateAsync(user);

                    return RedirectToPage();
                }
                else
                {
                    TempData["Error"] = "Usuário com o CPF fornecido não encontrado.";
                }
            }

            return Page();
        }
    }
}