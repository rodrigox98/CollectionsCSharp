using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CList.Src
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public int Idade { get; set; }  
        public string Raca { get; set; }

        public Cachorro(string nome, int idade, string raca)
        {
            Nome = nome;
            Idade = idade;
            Raca = raca;
        }

        public void Latir()
        {
            Console.WriteLine("Au au au");
        }

        public override string ToString()
        {
            return $"Esse é o {Nome}, {Nome} é um bom cachorro, ele tem {Idade} anos e sua raça é : {Raca} ";
        }
    }
}
