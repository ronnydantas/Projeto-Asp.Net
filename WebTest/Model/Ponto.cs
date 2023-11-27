using System;

namespace WebTest.Model
{
    public class Ponto
    {
        public Ponto() { }
        public int? Id { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan HorarioEntrada { get; set; }
        public TimeSpan? HorarioSaida { get; set; }
        public string? AuthDbContextUserId { get; set; }
        public string NomeUsuario { get; set; }
        public virtual AuthDbContext AuthDbContext { get; set; }
    }
}
