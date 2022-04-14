using OrientadoAObjetoVeiculos.InterfaceFactory;
using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class CarroFactory : ICarroFactory
    {
        public ICarro BuildHB20(IMotorFactory motorFactory, IPortasFactory portasFactory, IRodasFactory rodasFactory)
        {
            return new Carro("HB20", "ABC-1234", "Preto", "Daniel", 2015, motorFactory.BuildMotorHB20(), portasFactory.BuildPortaHB20(), rodasFactory.BuildRodaHB20(), 50, 193, 1120);
        }
        public ICarro BuildFordKa(IMotorFactory motorFactory, IPortasFactory portasFactory, IRodasFactory rodasFactory)
        {
            return new Carro("FordKa Hatch", "CBA-4321", "Branco", "Carlos", 2020, motorFactory.BuildMotorFordKa(), portasFactory.BuildPortaFordKa(), rodasFactory.BuildRodaFordKa(), 51, 166, 1007);
        }
    }
}
