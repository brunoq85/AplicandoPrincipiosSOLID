using System;

namespace ExemploParte7
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade calculaDescontoFidelidade = new CalculaDescontoFidelidade();
            ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory = new CalculaDescontoStatusContaFactory();


            GerenciadorDeDesconto gerenciadorDeDesconto = new GerenciadorDeDesconto(calculaDescontoFidelidade, calculaDescontoStatusContaFactory);
            var clienteComum = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
            var clienteEspecial = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
            var clienteVip = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 10);

            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum} => valor do desconto é: {clienteComum}");
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial} => valor do desconto é: {clienteEspecial}");
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVip} => valor do desconto é: {clienteVip}");
            Console.WriteLine();

            clienteComum = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
            clienteEspecial = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
            clienteVip = gerenciadorDeDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 4);

            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum} => valor do desconto é: {clienteComum}");
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial} => valor do desconto é: {clienteEspecial}");
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVip} => valor do desconto é: {clienteVip}");

            Console.ReadLine();
        }
    }
}
