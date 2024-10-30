using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N - ");
            uint N = uint.Parse(Console.ReadLine());
            long squareN = 0; 
            for (int i = 1; i <= N; i++)
            {
                squareN += 2 * i - 1;
                Console.WriteLine("{0}^2 - {1}",i, squareN);
            }
            Console.ReadKey();
        }
    }
}
