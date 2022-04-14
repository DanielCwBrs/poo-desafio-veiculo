using OrientadoAObjetoVeiculos.Factory;
using OrientadoAObjetoVeiculos.InterfaceFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Interfaces
{
    public interface ICarroFactory
    {
        ICarro BuildHB20(IMotorFactory motorFactory, IPortasFactory portasFactory, IRodasFactory rodasFactory);
        ICarro BuildFordKa(IMotorFactory motorFactory, IPortasFactory portasFactory, IRodasFactory rodasFactory);
    }
}
