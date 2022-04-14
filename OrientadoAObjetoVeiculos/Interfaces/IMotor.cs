using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Interfaces
{
    public interface IMotor
    {
        long MotorCavalos { get; set; }
        decimal Torque { get; set; }
        Enuns.TipoStatusMotor StatusMotor { get; set; }
        double Combustivel { get; set; }

        void Ligar();
        double Acelerar(long tempo, double peso, double velocidadeAtual);
        void Desligar();
        
        //IMotor BuildMotorHB20(); //Precisa de injeção de depêndencia para poder utilizar na classe Program
    }
}
