namespace ExemploParte7
{
    class CalculoDescontoClienteVip : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);
        }
    }
}
