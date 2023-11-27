using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;
using WebTest.Model;

namespace WebTest.Pages
{
    public class FeriasAdminModel : PageModel
    {
        private readonly AuthDbContext _dbContext;

        public FeriasAdminModel(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public string CPF { get; set; }

        [BindProperty]
        public DateTime DataInicio { get; set; }

        [BindProperty]
        public DateTime DataFim { get; set; }

        public string NomeUsuario { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostSaveFerias()
        {
            var usuario = _dbContext.Users.FirstOrDefault(u => u.Cpf == CPF);

            if (usuario != null)
            {
                var ferias = new Ferias
                {
                    UserId = usuario.Id,
                    DataInicio = DataInicio,
                    DataFim = DataFim,
                    NomeUsuario = usuario.Nome
                };

                _dbContext.Ferias.Add(ferias);
                _dbContext.SaveChanges();
                return RedirectToPage();
            }
            else
            {
                TempData["Error"] = "Usuário com o CPF fornecido não encontrado.";
                return Page();
            }
        }
    }
}
