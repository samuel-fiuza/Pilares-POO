using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO
{
    internal class Livro
    {
        //Atributos
        public string Titulo;
        public string Autor;
        public int Paginas;
        //Metodos
        public Livro(string Titulo, string Autor, int Paginas)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Paginas = Paginas;
        }
        public void Exibir()
        {
            Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | número de páginas: {Paginas}");
        }
    }
}
