using OrientadoAObjetoVeiculos.Enuns;
using OrientadoAObjetoVeiculos.Interfaces;
using System;

namespace OrientadoAObjetoVeiculos
{
    public class Motor : IMotor
    {
        public long MotorCavalos { get; set; }
        public decimal Torque { get; set; }
        public TipoStatusMotor StatusMotor { get; set; }
        public double Combustivel { get; set; }

        public Motor(long motorCavalos, decimal torque, double combustivel)
        {
            MotorCavalos = motorCavalos;
            Torque = torque;
            Combustivel = combustivel;
            StatusMotor = Enuns.TipoStatusMotor.Desligado;
        }

        public void Ligar()
        {
            StatusMotor = Enuns.TipoStatusMotor.Ligado;
        }

        public double Acelerar(long tempo, double peso, double velocidadeAtual)
        {
            double aceleracao = MotorCavalos / peso;
            velocidadeAtual += aceleracao * tempo;

            return velocidadeAtual / 1000;
        }

        public void Desligar()
        {
            StatusMotor = Enuns.TipoStatusMotor.Desligado;
        }

        public override string ToString()
        {
            return "\n" + $@"##############################################################" +
                    "\nDescrição do motor: " + "\n" +
                    $"\t Status do motor: {(StatusMotor == Enuns.TipoStatusMotor.Ligado ? "Ligado" : "Desligado")}" + "\n" +
                    $"\t Torque: {Torque}" + "\n" +
                    $"\t Potência: {MotorCavalos}" + "\n" +
                    "##############################################################";
        }

        //public IMotor BuildMotorHB20()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
