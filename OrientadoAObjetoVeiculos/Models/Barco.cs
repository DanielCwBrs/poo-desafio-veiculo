using OrientadoAObjetoVeiculos.Interfaces;
using System;

namespace OrientadoAObjetoVeiculos
{
    public class Barco : VeiculoMotorizado, IBarco
    {
        public string NomeBarco { get; set; }
        public string ModeloBarco { get; set; }
        public int QuantidadeMarinheiros { get; set; }
        public double ComprimentoBarco { get; set; }

        public Barco(IMotor motor, string nomeBarco, string modeloBarco, int quantidadeMarinheiros, double comprimentoBarco, double velocidadeMaxima, double capacidadeTanque, double peso) : base
            (motor, velocidadeMaxima, capacidadeTanque, peso)
        {
            VelocidadeAtual = 0;
            NomeBarco = nomeBarco;
            ModeloBarco = modeloBarco;
            QuantidadeMarinheiros = quantidadeMarinheiros;
            ComprimentoBarco = comprimentoBarco;
        }
        
        public override string ToString()
        {
            return "\n" + $@"##############################################################" +
                    "\nDescrição do barco:" + "\n" +
                    $"\t Nome do barco: {NomeBarco}" + "\n" +
                    $"\t Modelo do barco: {ModeloBarco}" + "\n" +
                    $"\t Quantidade de marinheiros: {QuantidadeMarinheiros}" + "\n" +
                    $"\t Capacidade do tanque {CapacidadeTanque} litros" + "\n" +
                    $"\t Comprimento do barco: {ComprimentoBarco}" + "\n" +
                    "##############################################################";
        }

        
    }
}
