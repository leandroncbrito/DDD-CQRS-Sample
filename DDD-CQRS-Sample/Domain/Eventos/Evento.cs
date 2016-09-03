using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Eventos
{
    public class Evento
    {
        protected Evento() { }

        public Guid EventoId { get; private set; }

        public Guid EspectaculoId { get; private set; }        

        public string Local { get; private set; }

        public string Endereco { get; private set; }

        public DateTime DataApresentacao { get; private set; }

        public DateTime Horario { get; private set; }

        public DateTime Inicio { get; private set; }

        public DateTime Termino { get; private set; }

        public int IngressosTotais { get; private set; }

        public int IngressosDisponiveis { get; private set; }

        public void Registrar()
        {
            if (!this.RegistrarEventoScopeValido())
                return;
        }
    }
}
