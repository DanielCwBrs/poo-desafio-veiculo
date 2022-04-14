using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos
{
    public class Rodas : IRodas
    {
        public string MarcaRoda { get; set; }
        public int QuantidadeRodas { get; set; }
        public int Aro { get; set; }
        
        public Rodas(string marcaRoda, int quantidadeRodas, int aro)
        {
            MarcaRoda = marcaRoda;
            QuantidadeRodas = quantidadeRodas;
            Aro = aro;
        }
        public override string ToString()
        {
            return "\n" + $@"##############################################################" +
                    "\nDescrição rodas:" + "\n" +
                    $"\t Marca da roda: {MarcaRoda}" + "\n" +
                    $"\t Quantidade de roda: {QuantidadeRodas}" + "\n" +
                    $"\t Aro: {Aro}" + "\n" +
                    "##############################################################";
        }
    }
}
