using System;

namespace WebTest.Model
{
    public class Rescisao
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Motivo { get; set; }
        public DateTime DataRescisao { get; set; }
        public string NomeUsuario { get; set; }
        public virtual AuthDbContext AuthDbContext { get; set; }
    }
}
