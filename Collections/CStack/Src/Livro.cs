using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStack.Src
{
    internal class Livro
    {
        public string Nome { get; set; }

        public int nPaginas { get; set; }

        public string Genero { get; set; }



        public Livro(string nome, int n_paginas, string genero)
        {
            Nome = nome;
            nPaginas = n_paginas;
            Genero = genero;
        }

        public override string ToString()
        {
            return $"Livro :{Nome}, Genêro : {Genero}, Páginas: {nPaginas}";
        }


    }
}
