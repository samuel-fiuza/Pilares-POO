using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO
{
    internal class ContaBancaria
    {
        private string Titular;
        private double Saldo;

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido");
            }
            Saldo += valor;
            Console.WriteLine($"Saldo Atualizado para: {Saldo}");
        }
    }
}
