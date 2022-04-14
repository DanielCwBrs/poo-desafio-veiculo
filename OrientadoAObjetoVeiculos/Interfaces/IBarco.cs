using OrientadoAObjetoVeiculos.Interfaces;

namespace OrientadoAObjetoVeiculos
{
    public interface IBarco
    {
        string NomeBarco { get; set; }
        int QuantidadeMarinheiros { get; set; }
        double ComprimentoBarco { get; set; }
        string ModeloBarco { get; set; }

    }
}