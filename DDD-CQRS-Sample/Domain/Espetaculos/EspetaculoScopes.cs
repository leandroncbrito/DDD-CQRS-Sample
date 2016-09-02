using Core.Domain.ValueObjects;
using System;

namespace Domain.Espetaculos
{
    public static class EspetaculoScopes
    {
        public static bool RegistrarEspetaculoScopeValido(this Espetaculo espetaculo)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotNullOrEmpty(espetaculo.Nome, "Nome é obrigatório"),
                AssertionConcern.AssertNotNullOrEmpty(espetaculo.Sinopse, "Sinopse é obrigatória"),
                AssertionConcern.AssertNotNullOrEmpty(espetaculo.GeneroId.ToString(), "Gênero é obrigatório"),
                AssertionConcern.AssertNotNullOrEmpty(espetaculo.TipoId.ToString(), "Tipo é obrigatório")
            );
        }
    }
}