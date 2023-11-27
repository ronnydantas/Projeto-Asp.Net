using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using WebTest.Interface;
using WebTest.Model;
using System.Collections.Generic;

public class PontoService : IPontoService
{
    private readonly IPontoRepository _pontoRepository;
    private readonly UserManager<ApplicationUser> _userManager;

    public PontoService(IPontoRepository pontoRepository, UserManager<ApplicationUser> userManager)
    {
        _pontoRepository = pontoRepository;
        _userManager = userManager;
    }

    public async Task<List<Ponto>> GetAllPontos()
    {
        return await _pontoRepository.GetAllPontos();
    }


    public async Task<bool> AdicionarPonto(string userId)
    {
        try
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new Exception("Usuário não encontrado.");
            }

            Ponto ultimoPonto = await _pontoRepository.GetUltimoPontoByUserAndDay(userId, DateTime.Today);

            if (ultimoPonto == null)
            {
                Ponto novoPonto = new Ponto
                {
                    Dia = DateTime.Today,
                    HorarioEntrada = DateTime.Now.TimeOfDay,
                    AuthDbContextUserId = userId,
                    NomeUsuario = user.Nome
                };
                await _pontoRepository.CreatePonto(novoPonto);
            }
            else if (ultimoPonto.HorarioSaida == null)
            {
                ultimoPonto.HorarioSaida = DateTime.Now.TimeOfDay;
                await _pontoRepository.UpdatePonto(ultimoPonto);
            }
            else
            {
                throw new Exception("Erro ao bater o ponto. Já bateu ponto de entrada e de saída hoje.");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return true;
    }
}
