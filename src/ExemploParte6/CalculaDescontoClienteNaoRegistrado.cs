namespace ExemploParte6
{
    public class CalculaDescontoClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}
