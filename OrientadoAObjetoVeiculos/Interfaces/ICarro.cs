using OrientadoAObjetoVeiculos.Interfaces;

namespace OrientadoAObjetoVeiculos
{
    public interface ICarro
    {
        string NomeProprietario { get; set; }
        string NomeCarro { get; set; }
        string Placa { get; set; }
        string Cor { get; set; }
        int AnoVeiculo { get; set; }
        IPortas Portas { get; set; }
        IRodas Rodas { get; set; }

        string DarTranco();
    }
}