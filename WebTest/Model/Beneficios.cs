namespace WebTest.Model
{
    public class Beneficios
    {
        public Beneficios() { }
        public int? Id { get; set; }
        public int Va { get; set; }
        public int Vt { get; set; }
        public int Vr { get; set; }
        public string NomeUsuario { get; set; }
        public virtual AuthDbContext AuthDbContext { get; set; }
    }
}
