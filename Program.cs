using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coloque aqui o seu codigo
        
  Console.WriteLine("insira o x");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insira o Y");
            double Y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && Y > 0)
                Console.WriteLine("1º quadrante");
            if (x < 0 && Y > 0)
                Console.WriteLine("2º quadrante");
            if (x < 0 && Y < 0)
                Console.WriteLine("3º quadrante");
            if (x > 0 && Y < 0)
                Console.WriteLine("4º quadrante");
            if (x == 0 && Y == 0)
                Console.WriteLine("Origem do referencial");
        }
    }
}
