using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Models
{
    public class Veiculo : IVeiculo
    {
        public double VelocidadeAtual { get; set; }

        public Veiculo()
        {
            VelocidadeAtual = 0;
        }
        public string Andar()
        {
            if (VelocidadeAtual >= 0)
            {
                VelocidadeAtual += 10;
                Console.WriteLine($"RPM: {VelocidadeAtual}km/h");
            }
            
            return "Acelerando!";
        }
        public string Frear()
        {
            if (VelocidadeAtual > 0)
            {
                VelocidadeAtual -= 10;
                Console.WriteLine($"RPM: {VelocidadeAtual}km/h");
            }
            else if (VelocidadeAtual == 0)
                Console.WriteLine("Veículo parado!");

            return "Veiculo freando!";
        }

        public string VirarEsquerda()
        {
            return "Virando à esquerda"!;
        }

        public string VirarDireita()
        {
            return "Virando à direita!";
        }

    }
        
    
}
