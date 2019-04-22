using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X1Y1_X2Y2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Давай измерим расстояние между двумя точками. \nВведи координаты X первой точки:");
                string sx1 = Console.ReadLine();
                double x1 = double.Parse(sx1);
            Console.WriteLine("Введи Y первой точки:");
                string sy1 = Console.ReadLine();
                double y1 = double.Parse(sy1);
            Console.WriteLine("Введи X второй точки:");
                string sx2 = Console.ReadLine();
                double x2 = double.Parse(sx2);
            Console.WriteLine("Введи Y второй точки:");
                string sy2 = Console.ReadLine();
                double y2 = double.Parse(sy2);

                double r;
                r = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

            Console.WriteLine("Расстояние между данными точками равно {0:F2}",  r);

            Console.ReadKey();
        }
    }
}
