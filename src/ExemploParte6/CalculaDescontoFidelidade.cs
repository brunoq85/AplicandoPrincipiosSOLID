using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploParte6
{
    public class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicaDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = 
                (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) 
                ? 
                (decimal)5 / 100 
                : 
                (decimal)tempoDeContaEmAnos / 100;

            return preco - (descontoPorFidelidade * preco);
        }
    }
}
