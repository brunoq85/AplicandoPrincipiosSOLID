using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploParte4
{
    public class GerenciadorDeDesconto
    {
        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = precoProduto;
                    break;

                case StatusContaCliente.ClienteComum:
                    //precoAposDesconto = (precoProduto - (0.1m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.1m * precoProduto));

                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    
                    break;

                case StatusContaCliente.ClienteEspecial:
                    //precoAposDesconto = (0.7m * precoProduto) - descontoPorFidelidade * (0.7m * precoProduto);

                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);

                    break;

                case StatusContaCliente.ClienteVip:
                    //precoAposDesconto = (precoProduto - (0.5m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.5m * precoProduto));

                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);

                    break;
                default:
                    throw new NotImplementedException();
            }

            return precoAposDesconto;
        }
    }
}
