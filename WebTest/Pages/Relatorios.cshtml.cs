using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using WebTest.Model;
using WebTest.ViewModels;

namespace WebTest.Pages
{
    public class RelatoriosModel : PageModel
    {
        private readonly AuthDbContext _dbContext;

        public List<FuncionarioViewModel> Funcionarios { get; set; }

        public RelatoriosModel(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Funcionarios = _dbContext.Users
                .Select(u => new FuncionarioViewModel
                {
                    Nome = u.Nome,
                    Cargo = u.Cargo,
                    Salario = u.Salario
                })
                .ToList();
        }
    }
}