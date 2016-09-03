using Cadastro.Application.ViewModels;
using Domain.Espetaculos;

namespace Cadastro.Application.Adapter
{
    public class EspetaculoAdapter
    {
        public static EspetaculoViewModel ToViewModel(Espetaculo espetaculo)
        {
            return new EspetaculoViewModel()
            {
                EspetaculoId = espetaculo.EspetaculoId,
                GeneroId = espetaculo.GeneroId,
                TipoId = espetaculo.TipoId,
                Nome = espetaculo.Nome,
                Sinopse = espetaculo.Sinopse
            };
        }

        public static Espetaculo ToDomainModel(EspetaculoViewModel espetaculo)
        {
            return new Espetaculo(espetaculo.Nome, espetaculo.Sinopse, espetaculo.GeneroId, espetaculo.TipoId);
        }
    }
}
