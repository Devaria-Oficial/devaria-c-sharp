using ListaProdutosMercadoClasse.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaProdutosMercadoClasse
{
    class Program
    {
        /*
         
            Escrever um programa - OK 
            que recebe alguns produtos como argumento - OK 
            e validar se esse produtos estão na lista de itens disponíveis do mercado. - OK
            Caso estejam, avisar o usuário quais produtos estão disponíveis - OK
            e quais não estão e - OK
            exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado, 
            para que o usuário possa pedir na próxima vez. - OK

         
         */

        //Escrever um programa - OK 
        // que recebe alguns produtos como argumento - OK 
        static void Main(string[] argumentos)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.9 });
            produtosDisponiveis.Add(new Produto() { Nome = "Azeite", Preco = 14.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Refrigerante", Preco = 6.25 });
            produtosDisponiveis.Add(new Produto() { Nome = "Queijo", Preco = 12.75 });
            produtosDisponiveis.Add(new Produto() { Nome = "Frango", Preco = 62.80 });

            if (argumentos.Length == 0)
            {
                Console.WriteLine("Você não passou os produtos que deseja comprar");
                return;
            }

            // validar se esses produtos dos argumentos estão na lista de itens disponíveis do mercado. - OK
            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(produto =>
                        argumentos.Any(argumento => produto.Nome.ToUpper() == argumento.ToUpper()));

            // Caso estejam, avisar o usuário quais produtos estão disponíveis - OK
            foreach (var produto in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nós temos: {produto.ExibirDadosProduto()}");
            }

            // e quais não estão disponíveis - OK
            var produtosSelecionadosNaoDisponiveis = argumentos.Where(argumento =>
                    !produtosDisponiveis.Any(produto => produto.Nome.ToUpper() == argumento.ToUpper()));

            foreach(var produtoNaoDisponivel in produtosSelecionadosNaoDisponiveis)
            {
                Console.WriteLine($"Este produto nós não temos infelizmente =/ {produtoNaoDisponivel}");
            }

            // exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado, 
            // para que o usuário possa pedir na próxima vez. - OK
            var produtosOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto.Nome).ToList();

            foreach(var produtoOrdenado in produtosOrdenadosPorNome)
            {
                Console.WriteLine(produtoOrdenado.ExibirDadosProduto());
            }
        }
    }
}
