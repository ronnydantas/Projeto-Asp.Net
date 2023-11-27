using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebTest.Model
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }
        public DbSet<Ferias> Ferias { get; set; }
        public DbSet<Ponto> Ponto { get; set; }
        public DbSet<Beneficios> Beneficios { get; set; }
        public DbSet<Pagamentos> Pagamentos { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Rescisao> Rescisoes { get; set;}
    }
}
