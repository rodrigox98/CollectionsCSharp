using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQueue.Src
{
    public class Pessoa
    {
        public String Nome {get; set;}
        
        public int Idade { get; set; }

        public string Nacionalidade { get; set; }

        public Pessoa(string nome, int idade, string nacionalidade)
        {
            Nacionalidade = nacionalidade;
            Idade = idade;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Nome}, tem {Idade} anos e sua nacionalidade é:{Nacionalidade}.";

        }
    }
}
