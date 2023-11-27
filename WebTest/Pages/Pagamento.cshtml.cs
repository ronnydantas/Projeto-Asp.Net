using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using WebTest.Model;

namespace WebTest.Pages
{
    public class PagamentoModel : PageModel
    {
        private readonly AuthDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PagamentoModel(AuthDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public string Nome { get; set; }
        public double inss { get; set; }

        public void OnGet()
        {
            var user = _userManager.GetUserAsync(User).Result;
            Nome = user.Nome;

            var ultimoPagamento = _context.Pagamentos
                .Where(p => p.NomeUsuario == Nome)
                .OrderByDescending(p => p.Id)
                .FirstOrDefault();

            if (ultimoPagamento != null)
            {
                SalarioBruto = ultimoPagamento.SalarioBruto;
                SalarioLiquido = ultimoPagamento.SalarioLiquido * 0.9;
                inss = SalarioBruto - SalarioLiquido;
            }
        }
    }
}
