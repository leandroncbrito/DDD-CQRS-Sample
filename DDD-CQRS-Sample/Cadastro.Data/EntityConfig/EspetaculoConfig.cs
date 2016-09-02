using Domain.Espetaculos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.EntityConfig
{
    public class EspetaculoConfig : EntityTypeConfiguration<Espetaculo>
    {
        public EspetaculoConfig()
        {
            HasKey(x => new { x.EspetaculoId });

            Property(x => x.Nome)
                .IsRequired();

            Property(x => x.Sinopse)
                .IsRequired();

            Property(x => x.GeneroId)
                .IsRequired();

            Property(x => x.TipoId)
                .IsRequired();

            ToTable("Espetaculos");
        }
    }
}
