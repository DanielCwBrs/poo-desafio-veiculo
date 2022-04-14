namespace OrientadoAObjetoVeiculos.Models
{
    public interface IVeiculo
    {
        double VelocidadeAtual { get; set; }
        double Peso { get; set; }

        string Andar();
        string Frear();
        string VirarEsquerda();
        string VirarDireita();
    }
}