using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class BarcoFactory : IBarcoFactory
    {
        public IBarco BuildIntermarine(IMotorFactory motorFactory)
        {
            return new Barco(motorFactory.BuildMotorIntermarine(), "Intermarine", "42", 14, 13.7, 57, 1100, 13000);
        }
    }
}
