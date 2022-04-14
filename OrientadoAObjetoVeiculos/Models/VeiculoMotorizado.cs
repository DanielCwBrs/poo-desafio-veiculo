using OrientadoAObjetoVeiculos.Interfaces;
using System;

namespace OrientadoAObjetoVeiculos
{
    public class VeiculoMotorizado : IVeiculoMotorizado
    {
        public double VelocidadeMaxima { get; set; }
        public double VelocidadeAtual { get; set; }
        public double CapacidadeTanque { get; set; }
        public IMotor Motor { get; set; }
        public double Peso { get; set; }

        public VeiculoMotorizado(IMotor motor, double velocidadeMaxima, double capacidadeTanque, double peso)
        {
            Motor = motor;
            VelocidadeAtual = 0;
            VelocidadeMaxima = velocidadeMaxima;
            CapacidadeTanque = capacidadeTanque;
            Peso = peso;
        }
        public string Andar()
        {
            if (Motor.Combustivel > 0)
            {
                Motor.Combustivel -= 1;

                if (VelocidadeAtual < VelocidadeMaxima && VelocidadeAtual >= 0)
                {
                    VelocidadeAtual += Motor.Acelerar(5000, Peso, VelocidadeAtual);
                    Console.WriteLine($"RPM: {VelocidadeAtual.ToString("F2")}km/h combustivel atual {Motor.Combustivel} Litros");
                    SemCombustivel();
                }
                else if (VelocidadeAtual == 0 && Motor.Combustivel == 0)
                    Console.WriteLine("Veículo sem combustivel abasteça!");
                else
                {
                    Console.WriteLine("Velocidade máxima alcançada");
                    Console.WriteLine($"RPM: {VelocidadeAtual.ToString("F2")}km/h combustivel atual {Motor.Combustivel} Litros");
                    SemCombustivel(); //implementa-se o metodo novamente pois entrou no else
                }
            }
            return "Acelerando!";
        }
        public string Frear()
        {
            if (VelocidadeAtual > 0 && Motor.Combustivel > 0)
            {
                VelocidadeAtual -= 10;
                Motor.Combustivel -= 1;

                if(VelocidadeAtual < 0)
                {
                    VelocidadeAtual = 0;
                }
                Console.WriteLine($"RPM: {VelocidadeAtual.ToString("F2")}km/h combustivel atual {Motor.Combustivel}");
                Console.WriteLine("Veículo freando!");
                SemCombustivel();
            }
            else if (VelocidadeAtual == 0)
                Console.WriteLine("veículo parado!");

            return "Veiculo freando!";
        }
        

        public void SemCombustivel()
        {
            if (VelocidadeAtual == 0)
                Console.WriteLine("Veículo parado!");
            else if (Motor.Combustivel > 0 && Motor.Combustivel <= 5)
                Console.WriteLine("Combustivel na reserva!");
            else if (Motor.Combustivel == 0)
            {
                for (int i = 0; i < VelocidadeAtual;) //O veículo começa a parar, pega a velocidade atual e subtrai
                {
                    Console.WriteLine("Sem combustivel!! Parando veículo!");
                    VelocidadeAtual -= Motor.Acelerar(5000, Peso, VelocidadeAtual);
                    if(VelocidadeAtual < 0)
                    {
                        VelocidadeAtual = 0;
                    }
                    Console.WriteLine(VelocidadeAtual.ToString("F2") + "km/h");
                }
                Console.WriteLine("Veiculo parado, aperte E para abastecer!");
            }
        }
        public string VirarEsquerda()
        {
            return "Virando à esquerda"!;
        }

        public string VirarDireita()
        {
            return "Virando à direita!";
        }
        public string SetAbastecer()
        {
            Motor.Combustivel = 30;
            Console.WriteLine($"Carro abastecido com {Motor.Combustivel} litros");

            return "Abastecido!";
        }

        
    }
}
