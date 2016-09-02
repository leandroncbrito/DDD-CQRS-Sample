using Cadastro.Data.EntityConfig;
using Domain.Espetaculos;
using Domain.Eventos;
using Domain.Generos;
using Domain.Tipos;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Cadastro.Data.Context
{
    public class CadastroContext : DbContext
    {
        public CadastroContext() : base("DefaultConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Espetaculo> Espetaculos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Configs
            modelBuilder.Configurations.Add(new EspetaculoConfig());
            modelBuilder.Configurations.Add(new EventoConfig());
            modelBuilder.Configurations.Add(new GeneroConfig());
            modelBuilder.Configurations.Add(new TipoConfig());
        }
    }
}
