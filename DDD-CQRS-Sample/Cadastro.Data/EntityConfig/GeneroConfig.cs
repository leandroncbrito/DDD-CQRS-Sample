using Domain.Generos;
using System.Data.Entity.ModelConfiguration;

namespace Cadastro.Data.EntityConfig
{
    public class GeneroConfig : EntityTypeConfiguration<Genero>
    {
        public GeneroConfig()
        {
            HasKey(x => new { x.GeneroId });

            Property(x => x.Nome)
                .IsRequired();

            ToTable("Generos");
        }               

    }
}
