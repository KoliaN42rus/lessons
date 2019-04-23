using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassIndex
{
    class Program //Николай Ничуговский
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует программа по вычислению нормальной массы тела.\nВведите Ваш вес в кг: ");
            double mass = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваш рост в см: ");
            double height = double.Parse(Console.ReadLine());

            double massInd = mass / ((height/100)*(height / 100));

                if (massInd <= 19)
                {
                    Console.WriteLine("Нормальный индекс равен 20-25, Ваш индекс = {0:F0} и Вам нужно набирать вес!", massInd);
                }
                else if (massInd >= 20 && massInd <= 25)
                {
                    Console.WriteLine("Нормальный индекс равен 20-25, Ваш индекс = {0:F0} и у Вас все норм))!", massInd);
                }
                else
                {
                    Console.WriteLine("Нормальный индекс равен 20-25, Ваш индекс = {0:F0} и Вам нужно похудеть!", massInd);
                }
                 Console.ReadKey();
        }
    }
}
