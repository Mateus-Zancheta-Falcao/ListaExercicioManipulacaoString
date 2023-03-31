using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            char[] arrayNome = nome.ToCharArray();

            for (int i = 0; i < arrayNome.Length; i++)
            {
                for (int j = 0; j < quantidade; j++)
                {
                    arrayNome[i]++;
                }
            }

            Console.Write($"\n{nome} passará a ser " );
            Console.Write(arrayNome);
            Console.ReadKey();
        }
    }
}
