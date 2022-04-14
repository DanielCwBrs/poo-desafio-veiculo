using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Models
{
    public class Bicicleta : Veiculo, IBicicleta
    {
        public string ModeloBicicleta { get; set; }
        public IRodas Rodas { get; set; }
        public Bicicleta(string modeloBicicleta, IRodas roda)
        {
            VelocidadeAtual = 0;
            ModeloBicicleta = modeloBicicleta;
            Rodas = roda;
        }
        public override string ToString()
        {
            return "\n" + $@"##############################################################" +
                    "\nDescrição da bicicleta: " + "\n" +
                    $"\t Modelo da bicicleta: {ModeloBicicleta}" + "\n" +
                    $"\t Veículo de {Rodas.QuantidadeRodas} rodas" + "\n" +
                    $"\t Marca de roda: {Rodas.MarcaRoda}" + "\n" +
                    $"\t Aro: {Rodas.Aro}" + "\n" +
                    "##############################################################";
        }
    }
}
