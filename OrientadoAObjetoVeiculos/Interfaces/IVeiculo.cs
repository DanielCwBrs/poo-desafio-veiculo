namespace OrientadoAObjetoVeiculos.Models
{
    public interface IVeiculo
    {
        double VelocidadeAtual { get; set; }

        string Andar();
        string Frear();
        string VirarEsquerda();
        string VirarDireita();
    }
}