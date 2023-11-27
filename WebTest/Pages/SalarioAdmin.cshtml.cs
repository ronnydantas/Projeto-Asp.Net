using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Model;

namespace WebTest.Pages
{
    public class SalarioAdminModel : PageModel
    {
        private readonly AuthDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public string CPF { get; set; }

        [BindProperty]
        public int PagamentoAdicional { get; set; }

        public SalarioAdminModel(AuthDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    var targetUser = _dbContext.Users.FirstOrDefault(u => u.Cpf == CPF);
                    if (targetUser != null)
                    {
                        var pagamentoExistente = _dbContext.Pagamentos.FirstOrDefault(p => p.NomeUsuario == targetUser.Nome);

                        if (pagamentoExistente == null)
                        {
                            var pagamentoAdicional = new Pagamentos
                            {
                                PagamentoAdicional = PagamentoAdicional,
                                NomeUsuario = targetUser.Nome,
                            };

                            _dbContext.Pagamentos.Add(pagamentoAdicional);
                        }
                        else
                        {
                            pagamentoExistente.SalarioBruto += PagamentoAdicional;
                            pagamentoExistente.SalarioLiquido = pagamentoExistente.SalarioBruto;
                            pagamentoExistente.PagamentoAdicional += PagamentoAdicional;
                        }

                        await _dbContext.SaveChangesAsync();

                        return RedirectToPage();
                    }
                    else
                    {
                        TempData["Error"] = "Usuário com o CPF fornecido não encontrado.";
                    }
                }
            }
            return Page();
        }
    }
}
