using System.Collections.Generic;
using System.Threading.Tasks;
using WebTest.Model;

namespace WebTest.Interface
{
    public interface IPontoService
    {
        Task<bool> AdicionarPonto(string userId);
        Task<List<Ponto>> GetAllPontos();
    }
}
