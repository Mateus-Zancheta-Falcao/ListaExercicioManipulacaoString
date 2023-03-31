using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma frase: ");
            string frase = Console.ReadLine();

            int textoSemEspacos = frase.Replace(" ", "").Length;
            Console.WriteLine("\n\nO texto tem {0} caracteres", textoSemEspacos);

            Console.ReadKey();
        }
    }
}
