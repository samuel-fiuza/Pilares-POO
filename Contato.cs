using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO
{
    internal class Contato
    {
        //Atributos
        public string Nome;
        public string Numero;
        public string Email;
        //Metodos
        public Contato(string nome, string numero, string email)
        {
            Nome = nome;
            Numero = numero;
            Email = email;
        }
        public Contato(string nome, string numero)
        {
            Nome = nome;
            Numero = numero;
        }
        public void Exibir()
        {
            Console.WriteLine($"| {Nome} | {Numero} | {Email} |");
        }
    }
}
