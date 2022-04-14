using OrientadoAObjetoVeiculos.Interfaces;

namespace OrientadoAObjetoVeiculos.Models
{
    public interface IBicicleta
    {
        string ModeloBicicleta { get; set; }
        IRodas Rodas { get; set; }
    }
}