using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8.src
{
    public class Animal
    {
      
        public string Nome { get; set; }    
        public string Especie { get; set; }    
        public string Cor { get ; set; }

        public Animal()
        {
        }

        public Animal(string nome, string especie, string cor)
        {
            Nome = nome;
            Especie = especie;
            Cor = cor;
        }

        public override string ToString()
        {
            return $"{Nome} {Especie} {Cor}";
        }
    }
}
