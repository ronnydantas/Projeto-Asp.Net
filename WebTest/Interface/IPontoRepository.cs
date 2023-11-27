﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using WebTest.Model;

namespace WebTest.Interface
{
    public interface IPontoRepository
    {
        Task<List<Ponto>> ListDados();
        Task<Ponto> GetPontoById(int IdUser);
        Task<Ponto> GetPontoByUserId(string userId);
        Task<int> UpdatePonto(Ponto user);
        Task<bool> DeletePontoAsync(int Id);
        Task<Ponto> CreatePonto(Ponto ponto);
        Task<Ponto> GetUltimoPontoByUserAndDay(string userId, DateTime dia);
        Task<List<Ponto>> GetPontosByFuncionarioAndMonth(string userId, int month, int year);
        Task<List<Ponto>> GetAllPontos();
    }
}
