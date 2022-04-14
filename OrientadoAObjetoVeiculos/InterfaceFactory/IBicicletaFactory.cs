using OrientadoAObjetoVeiculos.Factory;
using OrientadoAObjetoVeiculos.Interfaces;
using OrientadoAObjetoVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.InterfaceFactory
{
    public interface IBicicletaFactory
    {
        IBicicleta BuildBicicleta(IRodasFactory rodasFactory);
    }
}
