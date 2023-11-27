namespace WebTest.Model
{
    public class Pagamentos
    {
        public Pagamentos() { }
        public int Id { get; set; }
        public int SalarioBruto { get; set; }
        public int SalarioLiquido { get; set; }
        public int PagamentoAdicional { get; set; }
        public string NomeUsuario { get; set; }
        public virtual AuthDbContext AuthDbContext { get; set; }

    }
}
