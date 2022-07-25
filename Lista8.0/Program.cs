using Lista8.src;
using System;
using System.Collections.Generic;

namespace Lista8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();
            animais.Add(new Animal("ze", "cavalo", "marrom"));
            animais.Add(new Animal("caramelo", "cachorro", "mel"));
            animais.Add(new Animal("gotinha", "vaca", "malhada"));
            animais.Add(new Animal("Godo", "porco", "rosa"));

            animais.Insert(2, new Animal("rafa", "curupira", "verde"));

            animais.RemoveAt(animais.Count -1);
            animais.RemoveAt(1);

            foreach(Animal animal in animais)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
