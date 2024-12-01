using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Churras.Domain.Model.Entities
{
    public class EventoColegaConfirmado
    {
        public long ColegaKey { get; set; }
        public string ColegaNome { get; set; }
        public string OQueVaiLevar { get; set; }
    }
}
