using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO
{
    internal class Viagem
    {
        //Atributos
        public string Destino;
        public int Dias;
        public double ValorDiarias;
        //Metodos
        public Viagem(string destino, int dias, double valorDiarias)
        {
            Destino = destino;
            Dias = dias;
            ValorDiarias = valorDiarias;
        }
        public double CalcularTotal()
        {
            double total = Dias * ValorDiarias;
            return total;
        }
        public void Exibir()
        {
            Console.WriteLine($"A viagem será para {Destino}, vocês ficaram {Dias} dias, e o valor da diaria será {ValorDiarias}. O total da viagem será {CalcularTotal()}");
        }
    }
}
