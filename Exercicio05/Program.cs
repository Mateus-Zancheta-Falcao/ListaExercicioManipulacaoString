using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine($"{frase.ToUpper()}"); // Imprimir a frase em letras maiúsculas
            Console.WriteLine($"{frase.ToLower()}"); // Imprimir a frase em letras minúsculas
            Console.WriteLine($"{frase.Count()}"); // Imprimir a quantidade de caracteres da frase
            Console.WriteLine($"{frase.First()}"); // Imprimir a primeira palavra da frase
            Console.WriteLine($"{frase.Last()}"); // Imprimir a última palavra da frase

            Console.ReadKey();
        }
    }
}
