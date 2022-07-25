using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; 

namespace Queue8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Queue<Animal> Animais = new Queue<Animal>();
            
            Animais.Enqueue("Jose", "Azul","Crocrocrodile");
            Animais.Enqueue("Maria", "Verde", "Passarinho");
            Animais.Enqueue("Joao", "Rosa", "Turtle");
            Animais.Enqueue("Godo", "Lilas", "Urubu");

        foreach  (Animal animal in Animais)
            { 
            Console.WriteLine( animal.ToString() );

            }
        }
       

    }
     public class Animal
        { 
            public string Name { get; set; }    
            public string Cor { get; set; } 
            public string Especie { get; set; } 

            public Animal(string name, string cor, string especie)
            {
                Name = name;
                Cor = cor;
                Especie = especie;
            }
            public override string ToString()
            {
                return $"{Name} / {Cor} / {Especie}";

            }
        }
}
