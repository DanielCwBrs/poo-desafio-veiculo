using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Models
{
    public class Canoa : Veiculo, ICanoa
    {
        public int QuantidadeRemos { get; set; }

        public Canoa(int quantidadeRemos)
        {
            VelocidadeAtual = 0;
            QuantidadeRemos = quantidadeRemos;
        }
        public override string ToString()
        {
            return "\n" + $@"##############################################################" +
                    "\nDescrição da canoa: " + "\n" +
                    $"\t Quantidade de remos: {QuantidadeRemos}" + "\n" +
                    "##############################################################";
        }
    }
}
