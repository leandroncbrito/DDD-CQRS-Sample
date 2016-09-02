using Core.Domain.ValueObjects;

namespace Domain.Eventos
{
    public static class EventoScopes
    {
        public static bool RegistrarEventoScopeValido(this Evento evento)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotNullOrEmpty(evento.Local, "Local é obrigatório"),
                AssertionConcern.AssertNotNullOrEmpty(evento.Endereco, "Endereço é obrigatória"),
                AssertionConcern.AssertNotNull(evento.Inicio, "Início é obrigatório"),
                AssertionConcern.AssertNotNull(evento.Termino, "Término é obrigatório"),
                AssertionConcern.AssertNotNull(evento.Horario, "Horário é obrigatório"),
                AssertionConcern.AssertNotNull(evento.DataApresentacao, "Data de apresentação é obrigatória"),
                AssertionConcern.AssertNotNull(evento.IngressosDisponiveis, "Número de ingressos é obrigatório"),
                AssertionConcern.AssertAreEquals(evento.IngressosTotais.ToString(), "0", "Número de ingressos deve ser maior que zero")
            );
        }
    }
}
