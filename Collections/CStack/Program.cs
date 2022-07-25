using System;
using System.Collections.Generic;
using CStack.Src;

namespace CStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Livro> Livros = new Stack<Livro>();

            Livros.Push(new Livro("Senhor dos Anéis", 470, "Fantasia"));
            Livros.Push(new Livro("Duna", 670, "Ficção Científica"));
            Livros.Push(new Livro("Apologia de Sócrates", 320, "Filosofia"));


            Console.WriteLine($"Primeiro livro da pilha: {Livros.Peek()}");
            //Removendo primeiro livro da fila
            Livros.Pop();

            //Número de elementos
            Console.WriteLine($"Número de elementos na pilha: {Livros.Count}");

            Console.WriteLine("Lista de livros ");

            foreach (var item in Livros)
            {
                
                Console.WriteLine($"{item}");
            }
        }
    }
}
