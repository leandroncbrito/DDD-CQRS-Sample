using Domain.Eventos;
using System.Data.Entity.ModelConfiguration;

namespace Cadastro.Data.EntityConfig
{
    public class EventoConfig : EntityTypeConfiguration<Evento>
    {
        public EventoConfig()
        {
            HasKey(x => new { x.EventoId });

            Property(x => x.Local)
                .IsRequired();

            Property(x => x.Endereco)
                .IsRequired();

            Property(x => x.EspectaculoId)
                .IsRequired();

            Property(x => x.Horario)
                .IsRequired();

            Property(x => x.Inicio)
                .IsRequired();

            Property(x => x.Termino)
                .IsRequired();

            Property(x => x.DataApresentacao)
                .IsRequired();

            Property(x => x.IngressosTotais)
                .IsRequired();

            Property(x => x.IngressosDisponiveis)
                .IsRequired();

            ToTable("Eventos");
        }

    }
}
