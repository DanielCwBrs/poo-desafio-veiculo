using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Interfaces
{
    public interface IRodas
    {
        public string MarcaRoda { get; set; }
        public int QuantidadeRodas { get; set; }
        public int Aro { get; set; }
    }
}
