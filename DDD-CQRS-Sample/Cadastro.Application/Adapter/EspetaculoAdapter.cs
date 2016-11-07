using Cadastro.Application.ReadModels;
using Domain.Espetaculos;

namespace Cadastro.Application.Adapter
{
    public class EspetaculoAdapter
    {
        public static EspetaculoReadModel ToReadModel(Espetaculo espetaculo)
        {
            return new EspetaculoReadModel()
            {
                EspetaculoId = espetaculo.EspetaculoId,
                GeneroId = espetaculo.GeneroId,
                TipoId = espetaculo.TipoId,
                Nome = espetaculo.Nome,
                Sinopse = espetaculo.Sinopse
            };
        }

        public static Espetaculo ToDomainModel(EspetaculoReadModel espetaculo)
        {
            return new Espetaculo(espetaculo.Nome, espetaculo.Sinopse, espetaculo.GeneroId, espetaculo.TipoId);
        }
    }
}
