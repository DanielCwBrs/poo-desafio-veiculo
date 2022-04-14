using OrientadoAObjetoVeiculos.InterfaceFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class PortasFactory : IPortasFactory
    {
        public IPortas BuildPortaHB20()
        {
            return new Portas(4);
        }
        public IPortas BuildPortaFordKa()
        {
            return new Portas(2);
        }
        public IPortas BuildPortaA380()
        {
            return new Portas(2);
        }
    }
}
