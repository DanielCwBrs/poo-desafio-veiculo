using OrientadoAObjetoVeiculos.InterfaceFactory;
using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class AviaoFactory : IAviaoFactory
    {
        public IAviao BuildA380(IMotorFactory motorFactory, IPortasFactory portasFactory, IRodasFactory rodasFactory)
        {
            return new Aviao("Airbus A380", 853, 35.5, 560.000m, motorFactory.BuildMotorA380(), portasFactory.BuildPortaA380(), rodasFactory.BuildRodaA380(), 320000, 0, 910, 276800);
        }
    }
}
