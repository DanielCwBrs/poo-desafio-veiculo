using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class MotorFactory : IMotorFactory
    {
        public IMotor BuildMotorHB20()
        {
            return new Motor(105, 15, 30);
        }
        public IMotor BuildMotorA380()
        {
            return new Motor(414, 12, 30);
        }
        public IMotor BuildMotorFordKa()
        {
            return new Motor(105, 15, 30);
        }
        public IMotor BuildMotorIntermarine()
        {
            return new Motor(195, 14, 30);
        }
    }
}
