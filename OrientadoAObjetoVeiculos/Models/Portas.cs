using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos
{
    public class Portas : IPortas
    {
        public int QuantidadePortas { get; set; }
        
        public Portas(int quantidadePortas)
        {
            QuantidadePortas = quantidadePortas;
        }
        public string Abrir()
        {
            Console.WriteLine("Entrando no veículo!");

            return "De a ignição! aperte ENTER!";
        }
        public string Fechar()
        {
            Console.WriteLine("Saindo, aguarde!\n");
            Thread.Sleep(1000);

            return "Trancado a 7 chaves, quero ver abrir!";
        }
        public override string ToString()
        {
            return "\n" + $@"##############################################################" +
                    "\nDescrição portas: " + "\n" +
                    $"\t Quantidade de portas: {QuantidadePortas}" + "\n" +
                    "##############################################################";
        }
    }
}
