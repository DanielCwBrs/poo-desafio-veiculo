using OrientadoAObjetoVeiculos.Interfaces;
using System;

namespace OrientadoAObjetoVeiculos
{
    public class Aviao : VeiculoMotorizado, IAviao
    {
        public int QuantidadeAssentos { get; set; }
        public double ComprimentoAviao { get; set; }
        public string ModeloAviao { get; set; }
        public decimal CapacidadeCarga { get; set; }
        public IPortas Portas { get; set; }
        public IRodas Rodas { get; set; }

        public Aviao(string modeloAviao, int quantidadeAssentos, double comprimentoAviao, decimal capacidadeCarga, IMotor motor, IPortas porta, IRodas roda, double capacidadeTanque, double velocidadeAtual, double velocidadeMaxima, double peso) : base
            (motor, velocidadeMaxima, capacidadeTanque, peso)
        {
            VelocidadeAtual = 0;
            Portas = porta;
            Rodas = roda;
            QuantidadeAssentos = quantidadeAssentos;
            ComprimentoAviao = comprimentoAviao;
            CapacidadeCarga = capacidadeCarga;
            ModeloAviao = modeloAviao;
        }
        public string Pousar()
        {
            if (VelocidadeAtual > 0 && Motor.Combustivel > 0)
            {
                Frear();
            }
            else if (VelocidadeAtual == 0)
                Console.WriteLine("Avião pousou!");

            return "Avião desacelerando!";
        }

        public override string ToString()
        {
            return "\n" + $@"##############################################################" +
                    "\nDescrição do avião:" + "\n" +  
                    $"\t Modelo do avião: {ModeloAviao}" + "\n" +
                    $"\t Quantidade de assentos: {QuantidadeAssentos}" + "\n" +
                    $"\t Comprimento do avião: {ComprimentoAviao}" + "\n" +
                    $"\t Capacidade de carga: {CapacidadeCarga}kg" + "\n" +
                    $"\t Velocidade máxima de cruzeiro: {VelocidadeMaxima}km/h" + "\n" +
                    $"\t Capacidade do tanque {CapacidadeTanque} litros de querosene" + "\n" +
                    $"\t O avião possui {Rodas.QuantidadeRodas} rodas" + "\n" +
                    $"\t Marca da roda: {Rodas.MarcaRoda}" + "\n" +
                    $"\t Aro: {Rodas.Aro}" + "\n" +
                    "##############################################################";
        }

        
    }
}
