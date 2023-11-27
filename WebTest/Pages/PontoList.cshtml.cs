using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebTest.Interface;
using WebTest.Model;

namespace WebTest.Pages
{
    public class PontoListModel : PageModel
    {
        private readonly IPontoRepository _pontoRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public List<Ponto> Pontos { get; set; }

        public PontoListModel(IPontoRepository pontoRepository, UserManager<ApplicationUser> userManager)
        {
            _pontoRepository = pontoRepository;
            _userManager = userManager;
        }

        public async Task OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                Pontos = await _pontoRepository.GetPontosByFuncionarioAndMonth(user.Id, DateTime.Now.Month, DateTime.Now.Year);
            }
            else
            {
                Pontos = new List<Ponto>();
            }
        }
    }
}
