using System;

namespace Calculadora
{
    class Program
    {
        static float RealizarOperacao(float primeiroNumero, float segundoNumero, string operador)
        {
            switch (operador)
            {
                case "+": return primeiroNumero + segundoNumero;
                case "-": return primeiroNumero - segundoNumero;
                case "*": return primeiroNumero * segundoNumero;
                case "/": return primeiroNumero / segundoNumero;
                case "%": return primeiroNumero % segundoNumero;
                default: return 0f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            var primeiroNumeroString = Console.ReadLine();
            float primeiroNumero;

            bool isPrimeiroNumeroValido = float.TryParse(primeiroNumeroString, out primeiroNumero);
            if(!isPrimeiroNumeroValido)
            {
                Console.WriteLine("Primeiro número inválido");
                return;
            }

            Console.WriteLine("Informe o segundo número:");
            var segundoNumeroString = Console.ReadLine();
            float segundoNumero;

            bool isSegundoNumeroValido = float.TryParse(segundoNumeroString, out segundoNumero);
            if (!isSegundoNumeroValido)
            {
                Console.WriteLine("Primeiro número inválido");
                return;
            }

            Console.WriteLine("Informe o operador matemático:");
            var operador = Console.ReadLine();

            float resultado = RealizarOperacao(primeiroNumero, segundoNumero, operador);
            Console.WriteLine("O resultado da sua operação foi:" + resultado);
        }
    }
}
