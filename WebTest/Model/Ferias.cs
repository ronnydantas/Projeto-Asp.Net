using System;
using System.ComponentModel.DataAnnotations;

namespace WebTest.Model
{
    public class Ferias
    {
        public Ferias() { }
        public int? Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public DateTime DataFim { get; set; }

        public string NomeUsuario { get; set; }
        public virtual AuthDbContext AuthDbContext { get; set; }
    }
}
