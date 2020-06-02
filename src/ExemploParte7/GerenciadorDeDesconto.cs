using System;

namespace ExemploParte7
{
    public class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade _descontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade descontoFidelidade, 
            ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory)
        {
            _descontoFidelidade = descontoFidelidade;
            _calculaDescontoStatusContaFactory = calculaDescontoStatusContaFactory;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = 
                _calculaDescontoStatusContaFactory
                .GetCalculoDescontoStatusConta(statusContaCliente).AplicaDescontoStatusConta(precoProduto);

            precoAposDesconto =
                _descontoFidelidade.AplicaDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

            return precoAposDesconto;
        }
    }
}
