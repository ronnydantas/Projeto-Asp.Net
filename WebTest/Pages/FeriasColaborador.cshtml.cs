using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using WebTest.Model;

namespace WebTest.Pages
{
    public class FeriasColaboradorModel : PageModel
    {
        private readonly AuthDbContext _dbContext;

        public FeriasColaboradorModel(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Ferias> Ferias { get; set; } 

        public void OnGet()
        {
            var usuario = _dbContext.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (usuario != null)
            {
                Ferias = _dbContext.Ferias.Where(f => f.UserId == usuario.Id).ToList();
            }
        }
    }
}
