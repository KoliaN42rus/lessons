using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapMean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Поменяем значения переменных при помощи третьей временной переменной X. Введи значение A: ");
                int a = int.Parse(Console.ReadLine());
            Console.Write("Введи значение B: ");
                int b = int.Parse(Console.ReadLine());

                int x;

                x = a;
                a = b;
                b = x;

            Console.WriteLine("A = " +a);
            Console.WriteLine("B = " +b);

            Console.Write("Теперь то же самое, но без третьей переменной. Введи значение C: ");
                 int c = int.Parse(Console.ReadLine());
            Console.Write("Введи значение D: ");
                 int d = int.Parse(Console.ReadLine());

                c = (-c - d);
                d = (-c - d);
                c = (-c - d);

            Console.WriteLine("C = " + c);
            Console.Write("D = " + d);

            Console.ReadKey();

        }
    }
}
