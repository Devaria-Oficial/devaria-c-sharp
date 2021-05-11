using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAnimais.Classes
{
    class Animal
    {
        public string Nome { get; set; }
    }
    class Mamifero : Animal
    {
        public int QuantidadeDeMamas { get; set; }
    }

    class Reptil : Animal
    {
        public bool ControlaTemperaturaDoCorpo { get; set; } = false;
    }

    class Ave : Animal
    {
        public bool TemPena { get; set; } = true;
    }

    class Peixe : Animal
    {
        public int QuantidadeNadadeiras { get; set; }
    }
}
