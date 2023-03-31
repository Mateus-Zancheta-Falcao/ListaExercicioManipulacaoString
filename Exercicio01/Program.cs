using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma frase: ");
            string frase = Console.ReadLine();

            TextInfo text = CultureInfo.CurrentCulture.TextInfo;
            string textoConvertido = text.ToTitleCase(frase);

            Console.WriteLine("\n\n- Texto convertido -");
            Console.WriteLine($"{textoConvertido}");

            Console.ReadKey();
        }
    }
}
