using OrientadoAObjetoVeiculos.Interfaces;
using System;

namespace OrientadoAObjetoVeiculos
{
    public class Carro : VeiculoMotorizado, ICarro
    {
        public string NomeProprietario { get; set; }
        public string NomeCarro { get; set; }
        public string Placa { get; set; }   
        public string Cor { get; set; }
        public int AnoVeiculo { get; set; }
        public IPortas Portas { get; set; }
        public IRodas Rodas { get; set; }

        public Carro(string nomeCarro, string placa, string cor, string nomeProprietario, int anoVeiculo, IMotor motor, IPortas porta, IRodas roda, double capacidadeTanque, double velocidadeMaxima, double peso) : base
            (motor, velocidadeMaxima, capacidadeTanque, peso)
        {
            //Sem essas propriedades, uma exception será executado pois em ToString da classe HB20 retorna null
            VelocidadeAtual = 0;
            Portas = porta;
            Rodas = roda;
            NomeCarro = nomeCarro;
            Placa = placa;
            Cor = cor;
            NomeProprietario = nomeProprietario;
            AnoVeiculo = anoVeiculo;
            //VelocidadeAtual = velocidadeAtual;
        }

        public string DarTranco()
        {
            return "Não tá ligando, o negócio é empurrar!";
        }

        public override string ToString()
        {
            return  "\n" + @"##############################################################" +
                    "\nDescrição do veículo:" + "\n" +
                    $"\t Nome/Marca do veículo:  {NomeCarro}" + "\n" +
                    $"\t Placa do veículo: {Placa}" + "\n" +
                    $"\t Cor do veículo: {Cor}" + "\n" +
                    $"\t Nome do proprietário: {NomeProprietario}" + "\n" +
                    $"\t Ano do veículo: {AnoVeiculo}" + "\n" +
                    $"\t Capacidade do tanque: {CapacidadeTanque} litros" + "\n" +
                    $"\t Motor de {Motor.MotorCavalos} cavalos" + "\n" +
                    $"\t Veículo de {Portas.QuantidadePortas} portas" + "\n" +
                    $"\t Veículo de {Rodas.QuantidadeRodas} rodas" + "\n" +
                    $"\t Marca de roda: {Rodas.MarcaRoda}" + "\n" +
                    $"\t Aro: {Rodas.Aro}" + "\n" +
                    "##############################################################";
        }
    }
}
