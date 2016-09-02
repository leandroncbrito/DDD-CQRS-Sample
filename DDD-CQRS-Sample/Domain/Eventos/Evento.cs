using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Eventos
{
    public class Evento
    {
        public Evento()
        {

        }

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

        //public string EmpresaParceira { get; private set; }

        //public int IngressosPorPessoa { get; private set; }

        //public ICollection<Inscription> Inscriptions { get; set; }

        //public int FilaTotal { get; private set; }

        //public int FilaDisponivel { get; private set; }

        //public int SituacaoDaInscricao { get; private set; }

        //public int SituacaoDoEvento
        //{
        //    get
        //    {
        //        //Inscrições abertas
        //        if (this.IngressosDisponiveis > 0 && DateTime.Now.Between(this.EnrollStartAt, this.EnrollEndAt))
        //            return (int)Plateia.Entities.Enumerator.EventStatus.RegistrationOpen;
        //        //Lista de espera
        //        else if (this.TicketAvailable == 0 && this.QueueRemaining > 0 && DateTime.Now.Between(this.EnrollStartAt, this.EnrollEndAt))
        //            return (int)Plateia.Entities.Enumerator.EventStatus.WaitingList;
        //        else
        //            return (int)Plateia.Entities.Enumerator.EventStatus.RegistrationClosed;
        //    }
        //}

        public void Registrar()
        {
            if (!this.RegistrarEventoScopeValido())
                return;
        }
    }
}
