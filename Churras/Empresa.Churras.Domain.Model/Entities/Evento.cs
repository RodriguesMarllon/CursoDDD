using Kernel.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Churras.Domain.Model.Entities
{
    public class Evento : EntityKeySeq
    {
        public long DonoDaCasaKey { get; set; }
        public Colega DonoDaCasa { get; set; }
        public string TipoEvento { get; set; }
        public DateTime Dia { get; set; }
        public string Periodo { get; set; }
        public IList<EventoColegaConfirmado> ColegasConfirmados { get; set; }
    }
}
