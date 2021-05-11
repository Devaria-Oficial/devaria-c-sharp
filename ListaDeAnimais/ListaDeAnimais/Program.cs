using ListaDeAnimais.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeAnimais
{
    class Program
    {
        /*
            Escrever um programa - OK 
            Recebe um nome de animal vertebrado - OK 
            de acordo com um filtro, 
            identifica a qual dos grupos ele pertence (Mamífero, Réptil, Ave e Peixe), 
            e exibir os dados genéricos e exclusivos de cada grupo de animal. - OK
         */

        //Escrever um programa - OK 
        static void Main(string[] argumentos)
        {
            // Recebe um nome de animal vertebrado - OK
            Console.WriteLine("Favor digitar o nome do animal para buscarmos na nossa base:");
            var nomeAnimal = Console.ReadLine();
            if (string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrWhiteSpace(nomeAnimal))
            {
                Console.WriteLine("Favor passar um nome de animal vertebrado válido!");
                return;
            }

            var listaDeAnimais = new List<Animal>();
            listaDeAnimais.Add(new Mamifero() { Nome = "Vaca", QuantidadeDeMamas = 4 });
            listaDeAnimais.Add(new Reptil() { Nome = "Cobra" });
            listaDeAnimais.Add(new Ave() { Nome = "Gavião" });
            listaDeAnimais.Add(new Peixe() { Nome = "Tubarão", QuantidadeNadadeiras = 2 });

            //de acordo com um filtro para encontrar o animal - OK
            var animalSelecionado = listaDeAnimais.FirstOrDefault(animal => 
                    animal.Nome.ToUpper() == nomeAnimal.ToUpper());

            if(animalSelecionado == null)
            {
                Console.WriteLine("O Animal não está na nossa lista!");
                return;
            }

            //identifica a qual dos grupos ele pertence(Mamífero, Réptil, Ave e Peixe), 
            //e exibir os dados genéricos e exclusivos de cada grupo de animal. - OK
            if(animalSelecionado is Mamifero)
            {
                Console.WriteLine($"O animal encontrador é um mamífero com nome " +
                    $"{animalSelecionado.Nome} e quantidade de mamas = " +
                    $"  {((Mamifero)animalSelecionado).QuantidadeDeMamas}");
            }else if (animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontrador é um réptil com nome " +
                    $"{animalSelecionado.Nome} e não sabe controlar sua temperatura = " +
                    $"  {((Reptil)animalSelecionado).ControlaTemperaturaDoCorpo}");
            }
            else if (animalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrador é uma ave com nome " +
                    $"{animalSelecionado.Nome} e tem penas = " +
                    $"  {((Ave)animalSelecionado).TemPena}");
            }
            else if (animalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrador é um peixe com nome " +
                    $"{animalSelecionado.Nome} e tem = " +
                    $"  {((Peixe)animalSelecionado).QuantidadeNadadeiras} nadadeiras");
            }
            else
            {
                Console.WriteLine($"O animal encontrador é um animal e tem nome " +
                    $"{animalSelecionado.Nome}");
            }
        }
    }
}
