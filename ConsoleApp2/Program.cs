using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint A, B, C, count;
            count = 0;
            Console.WriteLine("Введите положительные числа");
            Console.Write("A - ");
            A = uint.Parse(Console.ReadLine());
            Console.Write("B - ");
            B = uint.Parse(Console.ReadLine());
            Console.Write("C - ");
            C = uint.Parse(Console.ReadLine());
            
            while (A >= C)
            {
                uint side = B;
                while (side >= C)
                {
                    side -= C;
                    count++;
                }
                A -= C;
            }
            Console.WriteLine("Количество квадратов - {0}",count);
            Console.ReadKey();
        }
    }
}
