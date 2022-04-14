using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.InterfaceFactory
{
    public interface IPortasFactory
    {
        IPortas BuildPortaHB20();
        IPortas BuildPortaFordKa();
        IPortas BuildPortaA380();
    }
}
