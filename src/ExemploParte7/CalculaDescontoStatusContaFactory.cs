using System;

namespace ExemploParte7
{
    public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calculaDescontoStatusConta;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calculaDescontoStatusConta = new CalculaDescontoClienteNaoRegistrado();
                    break;

                case StatusContaCliente.ClienteComum:
                    // 2- Calcula o desconto por status de conta de cliente
                    calculaDescontoStatusConta = new CalculaDescontoClienteComum();

                    break;

                case StatusContaCliente.ClienteEspecial:
                    // 2- Calcula o desconto por status de conta de cliente
                    calculaDescontoStatusConta = new CalculaDescontoClienteEspecial();

                    break;

                case StatusContaCliente.ClienteVip:
                    // 2- Calcula o desconto por status de conta de cliente
                    calculaDescontoStatusConta = new CalculoDescontoClienteVip();

                    break;
                default:
                    throw new NotImplementedException();
            }

            return calculaDescontoStatusConta;
        }
    }
}
