using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conta.API.Model
{
    public class Transferencia
    {
        public string origem { get; set; }
        public string destino { get; set; }
        public decimal valor { get; set; }
    }
}
