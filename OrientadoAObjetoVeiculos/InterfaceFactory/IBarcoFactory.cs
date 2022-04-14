using OrientadoAObjetoVeiculos.Factory;
using OrientadoAObjetoVeiculos.Interfaces;

namespace OrientadoAObjetoVeiculos
{
    public interface IBarcoFactory
    {
        IBarco BuildIntermarine(IMotorFactory motorFactory);
    }
}