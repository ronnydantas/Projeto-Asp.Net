using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using WebTest.Model;
namespace WebTest.Pages
{
    public class AbrirChamadoModel : PageModel
    {
        [BindProperty]
        public Chamado Chamado { get; set; }

        private readonly AuthDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public AbrirChamadoModel(AuthDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        private string GenerateRandomCode()
        {
            Random randNum = new Random();
            string codigo = "";

            for (int i = 0; i < 4; i++)
            {
                codigo += randNum.Next(10).ToString();
            }

            return codigo;
        }
        public void OnGet()
        {
            Chamado = new Chamado();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserAsync(User).Result;

                if (user != null)
                {
                    Chamado.Codigo = GenerateRandomCode();
                    Chamado.DataAbertura = DateTime.Now;
                    Chamado.NomeUsuario = user.Nome;
                    Chamado.Status = "Em Aberto";                    
                    _dbContext.Chamados.Add(Chamado);
                    _dbContext.SaveChanges();
                }

                return RedirectToPage(); 
            }


            return Page();
        }
    }
}
