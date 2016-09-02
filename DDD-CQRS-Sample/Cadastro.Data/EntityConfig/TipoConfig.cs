using Domain.Tipos;
using System.Data.Entity.ModelConfiguration;

namespace Cadastro.Data.EntityConfig
{
    public class TipoConfig : EntityTypeConfiguration<Tipo>
    {
        public TipoConfig()
        {
            HasKey(x => new { x.TipoId });

            Property(x => x.Nome)
                .IsRequired();

            ToTable("Tipos");
        }
    }
}
