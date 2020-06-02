namespace ExemploParte6
{
    public class CalculaDescontoClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
        }
    }
}
