using OrientadoAObjetoVeiculos.InterfaceFactory;
using OrientadoAObjetoVeiculos.Interfaces;
using OrientadoAObjetoVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class BicicletaFactory : IBicicletaFactory
    {
        public IBicicleta BuildBicicleta(IRodasFactory rodasFactory)
        {
            return new Bicicleta("Caloi", 15, rodasFactory.BuildRodaCaloi());
        }
    }
}
