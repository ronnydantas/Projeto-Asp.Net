using System;

namespace WebTest.Model
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Codigo { get; set;}
        public string Resumo { get; set;}
        public string Categoria { get; set;}
        public string Descricao { get; set;}
        public string Prioridade { get; set;}
        public string Status { get; set;}
        public DateTime DataAbertura { get; set;}
        public string NomeUsuario { get; set; }
        public virtual AuthDbContext AuthDbContext { get; set; }
    }
}
