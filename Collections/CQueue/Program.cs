using System;
using System.Collections.Generic;
using CQueue.Src;

namespace CQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Pessoa> listaPessoas = new Queue<Pessoa>();


            listaPessoas.Enqueue(new Pessoa("Larissa", 23, "Brasileira"));
            listaPessoas.Enqueue(new Pessoa("Britney", 17, "Americana"));
            listaPessoas.Enqueue(new Pessoa("Hideo", 32, "Japonesa"));
            listaPessoas.Enqueue(new Pessoa("Ragnar", 45, "Sueca"));
            listaPessoas.Enqueue(new Pessoa("Mohamed", 72, "Egípcia"));

            Console.WriteLine($"A primeira pessoa da fila é: {listaPessoas.Peek()}");
            //Removendo a primeira pessoa da fila
            listaPessoas.Dequeue();

            Console.WriteLine("Número de pessoas na fila : " + listaPessoas.Count);

            //Listando pessoas no console
            Console.WriteLine("Listando pessoas ");
            foreach (var pessoas in listaPessoas)
            {
                Console.WriteLine($"{pessoas}");
            }


        }
    }
}
