namespace ExemploParte6
{
    class CalculaDescontoClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
           return preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
        }
    }
}
