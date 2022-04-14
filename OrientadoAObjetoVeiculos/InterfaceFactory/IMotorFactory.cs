using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Interfaces
{
    public interface IMotorFactory
    {
        IMotor BuildMotorHB20();
        IMotor BuildMotorFordKa();
        IMotor BuildMotorA380();
        IMotor BuildMotorIntermarine();
    }
}
