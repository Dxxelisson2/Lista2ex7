using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o lado A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o lado B: ");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o lado C: ");
            c = Convert.ToInt16(Console.ReadLine());

            if (a == b || a == c || b == c)
            {
                Console.WriteLine(" É um triângulo isósceles!");

                if (a == b && b == c)
                {
                    Console.WriteLine("É um triângulo equilátero!");
                }
                else if (a != b && b != c && c != a)
                {
                    Console.WriteLine("É um triângulo escaleno!");
                }
            }

            else
            {
                Console.WriteLine("Não é um triângulo!");
            }

            Console.ReadKey();

        }
    }
}
