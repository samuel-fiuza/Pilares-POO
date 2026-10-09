using System;
using System.Collections.Generic;
using System.Text;

namespace Pilares_POO
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;

        //Metodo construtor  - Obriga um objeto a ser criado de uma forma
        //Não tem tipo de retorno
        //Tem o mesmo nome da classe
        public Carro(string marca, string modelo)
        {
            Marca = marca;

            Modelo = modelo;
        }


    }
}
