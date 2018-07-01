using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class ServicoTrocaOleo
    {
        public int Cod { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public Oleo Oleo { get; set; }
        public int QtdeLitro { get; set; }
    }
}
