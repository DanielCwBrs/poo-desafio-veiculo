using OrientadoAObjetoVeiculos.InterfaceFactory;
using OrientadoAObjetoVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetoVeiculos.Factory
{
    public class RodasFactory : IRodasFactory
    {
        public IRodas BuildRodaHB20()
        {
            return new Rodas("Pirelli", 4, 16);
        }
        public IRodas BuildRodaFordKa()
        {
            return new Rodas("Pirelli", 4, 18);
        }
        public IRodas BuildRodaA380()
        {
            return new Rodas("Michellin", 22, 16);
        }
        public IRodas BuildRodaCaloi()
        {
            return new Rodas("Levorin Praiero 26x1,95", 2, 26);
        }
    }
}
