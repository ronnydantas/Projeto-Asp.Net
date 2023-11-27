using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTest.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Pages
{
    public class RescisaoModel : PageModel
    {
        private readonly AuthDbContext _dbContext;

        [BindProperty]
        public string CPF { get; set; }
        [BindProperty]
        public string Nome { get; set; }
        [BindProperty]
        public string Cargo { get; set; }
        [BindProperty]
        public string Motivo { get; set; }
        [BindProperty]
        public DateTime DataRescisao { get; set; }

        public RescisaoModel(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(CPF) && string.IsNullOrEmpty(Nome) && string.IsNullOrEmpty(Cargo))
            {
                ModelState.AddModelError("", "Forneça pelo menos um filtro (CPF, Nome ou Cargo).");
                return Page();
            }

            var colaboradores = _dbContext.Users.Where(u =>
                (string.IsNullOrEmpty(CPF) || u.Cpf == CPF) &&
                (string.IsNullOrEmpty(Nome) || u.Nome == Nome) &&
                (string.IsNullOrEmpty(Cargo) || u.Cargo == Cargo)
            ).ToList();

            if (colaboradores.Count == 0)
            {
                ModelState.AddModelError("", "Nenhum colaborador encontrado com os filtros fornecidos.");
                return Page();
            }

            DateTime dataRescisao = DateTime.Now;

            foreach (var colaborador in colaboradores)
            {
                var rescisao = new Rescisao
                {
                    UserId = colaborador.Id,
                    Motivo = Motivo,
                    DataRescisao = dataRescisao,
                    NomeUsuario = colaborador.Nome
                };

                _dbContext.Rescisoes.Add(rescisao);
                colaborador.Situacao = "Desligado";
            }

            _dbContext.SaveChanges();

            return RedirectToPage();
        }
    }
}
