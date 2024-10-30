using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numberForSort = 0;
            ushort positive, negative;
            positive = negative = 0;
            Console.WriteLine("Введите целое число \nВведите 0 для окончания");
            do 
            {
                Console.Write("Число - ");
                numberForSort = long.Parse(Console.ReadLine());
                if (numberForSort > 0) positive++;
                else if (numberForSort < 0)negative++;
            } 
            while (numberForSort != 0);
            Console.Clear();
            if (positive > negative) Console.WriteLine("Количество положительный чисел больше чем отрицательных\n{0} > {1}", positive, negative);
            else if (positive < negative) Console.WriteLine("Количество положительный чисел меньше чем отрицательных\n{0} < {1}", positive, negative);
            else Console.WriteLine("Количество положительный и отрицательных чисел равно\n{0} = {1}", positive, negative);

            Console.ReadKey();
        }
    }
}
