using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis
{
    class Program
    {
        /*
            Escrever um programa que recebe alguns produtos como argumento, validar se esses produtos estão na lista de 
            itens disponíveis do mercado. Caso estejam, avisar o usuário quais produtos tem e quais não tem e, por último, 
            exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado, para que o usuário possa pedir 
            na próxima vez.
         */

        static void Main(string[] argumentos)
        {
            // criar a lista de produtos que nosso mercado tem
            List<string> produtosDisponiveis = new List<string>()
            {
                "pão", "leite", "manteiga", "requeijão", "refrigerante", "arroz", "alface", "Alface", "tomate", "frango", "doce"
            };

            // validar se os argumentos foram preenchidos
            try
            {
                // listar quais produtos informados do argumento tem na lista do mercado
                var produtosSelecionados = produtosDisponiveis.Where(produto => argumentos.Contains(produto)).ToList();
                foreach(var produtoSelecionado in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nós temos: {produtoSelecionado}");
                }

                // listar quais produtos informados no argumento não tem no mercado
                var produtosNaoDisponiveis = argumentos.Where(argumento => !produtosDisponiveis.Contains(argumento)).ToList();
                foreach(var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nós não temos infelizmente =/ : {produtoNaoDisponivel}");
                }

                // retornar a lista de produtos disponíveis do mercado ORDENADOS em ordem alfabética
                var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto).ToList();
                foreach(var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto disponível: ${produtoOrdenado}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos inválidos");
            }
        }
    }
}
