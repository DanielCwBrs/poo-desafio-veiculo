using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Interfaces
{
    public interface IVeiculoMotorizado
    {
        double VelocidadeMaxima { get; set; }
        double VelocidadeAtual { get; set; }
        double CapacidadeTanque { get; set; }
        IMotor Motor { get; set; }
        double Peso { get; set; }

        string Andar();
        string Frear();
        void SemCombustivel();
        string VirarEsquerda();
        string VirarDireita();
        string SetAbastecer();
    }
}
