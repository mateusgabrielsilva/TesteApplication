global using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;

namespace TesteApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=10.90.0.18;Initial Catalog=CARTAO_SISCRED_MORFEU_QA;Persist Security Info=True;User ID=SIS_CARTAO;Password=pwd");
        }

        public DbSet<Usuarios> USUARIOS_BOT_MANAGER { get; set; }
    }
}
