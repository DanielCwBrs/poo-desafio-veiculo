namespace OrientadoAObjetoVeiculos
{
    public interface IPortas
    {
        int QuantidadePortas { get; set; }

        string Abrir();
        string Fechar();
    }
}