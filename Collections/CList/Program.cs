using CList.Src;
using System;
using System.Collections.Generic;

namespace CList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cachorro pluto = new Cachorro("Pluto", 12, "Pastor Alemão");

            
            List<Cachorro> listaCachorro = new List<Cachorro>();

            //Lista de cachorros
            listaCachorro.Add(new Cachorro("Pluto", 12, "Pastor Alemão"));
            listaCachorro.Add(new Cachorro("Nasus", 360, "Cachorro Múmia"));
            listaCachorro.Add(new Cachorro("Pelu", 2, "Bulldog"));
            listaCachorro.Add(new Cachorro("Yellow", 4, "Labrador"));

            //Inserindo na posição 2
            listaCachorro.Insert(2,new Cachorro("Pretinho", 1, "Vira-Lata"));

            //Removendo do índice 1 
            listaCachorro.RemoveAt(1);


            //Removendo último animal da lista
            listaCachorro.RemoveAt(listaCachorro.Count - 1);

            
            //Imprimindo lista
            foreach(var cachorro in listaCachorro)
            {
                Console.WriteLine($"{cachorro}");
            }
        }

    }
}
