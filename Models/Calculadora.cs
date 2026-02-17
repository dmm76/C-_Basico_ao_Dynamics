using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace projeto01.Models
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"A soma de {a} + {b} é: {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"A subtração de {a} - {b} é: {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"A multiplicação de {a} * {b} é: {a * b}");
        }

        public void Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
            Console.WriteLine($"A divisão de {a} / {b} é: {a / b}");
            Console.WriteLine($"A resto da divisão é: {a % b}");
        }

        public void Potencia(int a, int b)
        {
            Console.WriteLine($"A potência de {a} elevado a {b} é: {Math.Pow(a, b)}");
        }

        public void Seno(int a)
        {
            double radians = a * (Math.PI / 180); // Convertendo graus para radianos
            Console.WriteLine($"O seno de {a} é: {Math.Round(Math.Sin(radians), 4)}");
        }

        public void Cosseno(int a)
        {
            double radians = a * (Math.PI / 180); // Convertendo graus para radianos
            Console.WriteLine($"O cosseno de {a} é: {Math.Round(Math.Cos(radians), 4)}");
        }

        public void Tangente(int a)
        {
            double radians = a * (Math.PI / 180); // Convertendo graus para radianos
            Console.WriteLine($"A tangente de {a} é: {Math.Round(Math.Tan(radians), 4)}");
        }

        public void RaizQuadrada(int a)
        {
            if (a < 0)
            {
                Console.WriteLine(
                    "Erro: Não é possível calcular a raiz quadrada de um número negativo."
                );
                return;
            }
            Console.WriteLine($"A raiz quadrada de {a} é: {Math.Sqrt(a)}");
        }
    }
}
