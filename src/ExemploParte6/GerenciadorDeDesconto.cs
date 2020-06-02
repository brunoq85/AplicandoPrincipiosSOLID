using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploParte6
{
    public class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade _descontoFidelidade;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade descontoFidelidade)
        {
            _descontoFidelidade = descontoFidelidade;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = new CalculaDescontoClienteNaoRegistrado().AplicaDescontoStatusConta(precoProduto);
                    precoAposDesconto = _descontoFidelidade.AplicaDescontoFidelidade(precoProduto, tempoDeContaEmAnos);
                    break;

                case StatusContaCliente.ClienteComum:
                    // 2- Calcula o desconto por status de conta de cliente
                    precoAposDesconto = new CalculaDescontoClienteComum().AplicaDescontoStatusConta(precoProduto);
                    // 1- Calcula o desconto por fidelidade
                    precoAposDesconto = _descontoFidelidade.AplicaDescontoFidelidade(precoProduto, tempoDeContaEmAnos);

                    break;

                case StatusContaCliente.ClienteEspecial:
                    // 2- Calcula o desconto por status de conta de cliente
                    precoAposDesconto = new CalculaDescontoClienteEspecial().AplicaDescontoStatusConta(precoProduto);
                    // 1- Calcula o desconto por fidelidade
                    precoAposDesconto = _descontoFidelidade.AplicaDescontoFidelidade(precoProduto, tempoDeContaEmAnos);

                    break;

                case StatusContaCliente.ClienteVip:
                    // 2- Calcula o desconto por status de conta de cliente
                    precoAposDesconto = new CalculoDescontoClienteVip().AplicaDescontoStatusConta(precoProduto);
                    // 1- Calcula o desconto por fidelidade
                    precoAposDesconto = _descontoFidelidade.AplicaDescontoFidelidade(precoProduto, tempoDeContaEmAnos);

                    break;
                default:
                    throw new NotImplementedException();
            }

            return precoAposDesconto;
        }
    }
}
