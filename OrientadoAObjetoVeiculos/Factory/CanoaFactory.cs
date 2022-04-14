using OrientadoAObjetoVeiculos.InterfaceFactory;
using OrientadoAObjetoVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class CanoaFactory : ICanoaFactory
    {
        public ICanoa BuildCanoa()
        {
            return new Canoa(2);
        }
    }
}
