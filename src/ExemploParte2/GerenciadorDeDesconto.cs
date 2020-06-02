using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploParte2
{
    class GerenciadorDeDesconto
    {
        public decimal AplicarDesconto(decimal precoProduto, int statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100;

            if (statusContaCliente == 1)
            {
                precoAposDesconto = precoProduto;
            }
            else if (statusContaCliente == 2)
            {
                precoAposDesconto = (precoProduto - (0.1m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.1m * precoProduto));
            }
            else if (statusContaCliente == 3)
            {
                precoAposDesconto = (0.7m * precoProduto) - descontoPorFidelidade * (0.7m * precoProduto);
            }
            else if (statusContaCliente == 4)
            {
                precoAposDesconto = (precoProduto - (0.5m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.5m * precoProduto));
            }

            return precoAposDesconto;
        }
    }
}
