using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("dame el primer numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero1 + numero2;
            Console.WriteLine("el resultado es : " + resultado);

            Console.ReadLine();

        }
    }
}
