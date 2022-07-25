using System;
using System.Collections.Generic;
using System.Collections;

namespace Stack8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Pilha de livros!");

            Stack<Livro> stack = new();

            stack.Push(new Livro("No seu Tem Pao"));
            stack.Push(new Livro("A Cabana"));
            stack.Push(new Livro("Minhas Plantas"));

            Console.WriteLine($"\n Quantidade de livros: {stack.Count}");

            Console.WriteLine($"\n Primeira livro da pilha: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"\n Quantidade de livros: {stack.Count}");

            foreach (var item in stack)
            {
                Console.WriteLine($"\n Os Livros restantes: {item}");

            }
        }
        public class Livro
        {
            public string Nome { get; set; }

            public Livro(string nome)
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return $"{Nome}";
            }

        }
    }
}
