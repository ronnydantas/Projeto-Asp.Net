using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebTest.Model;

namespace WebTest.Pages
{
    public class ChamadoAdminModel : PageModel
    {
        private readonly AuthDbContext _dbContext;

        public ChamadoAdminModel(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Chamado> GetChamados()
        {
            return _dbContext.Chamados.ToList();
        }

        public void OnGet()
        {
        }
    }
}
