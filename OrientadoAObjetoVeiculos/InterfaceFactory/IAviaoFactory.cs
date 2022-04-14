using OrientadoAObjetoVeiculos.InterfaceFactory;
using OrientadoAObjetoVeiculos.Interfaces;

namespace OrientadoAObjetoVeiculos.Factory
{
    public interface IAviaoFactory
    {
        IAviao BuildA380(IMotorFactory motorFactory, IPortasFactory portasFactory, IRodasFactory rodasFactory);
    }
}