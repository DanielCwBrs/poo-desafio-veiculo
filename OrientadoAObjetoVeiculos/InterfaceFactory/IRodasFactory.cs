using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.InterfaceFactory
{
    public interface IRodasFactory
    {
        IRodas BuildRodaHB20();
        IRodas BuildRodaFordKa();
        IRodas BuildRodaA380();
        IRodas BuildRodaCaloi();
    }
}
