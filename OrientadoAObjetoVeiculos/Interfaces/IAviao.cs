using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Interfaces
{
    public interface IAviao
    {
        int QuantidadeAssentos { get; set; }
        double ComprimentoAviao { get; set; }
        string ModeloAviao { get; set; }
        decimal CapacidadeCarga { get; set; }
        IPortas Portas { get; set; }
        IRodas Rodas { get; set; }

        string Pousar();
    }
}
