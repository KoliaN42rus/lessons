using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd
{
    class Program  //Ничуговский Николай. С клавиатуры вводятся числа, пока не будет введён 0
                   //Требуется подсчитать сумму всех нечетных положительных чисел. 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число"); 
            int odd = 0; int even = 0;  //И добавил четные, для разнообразия
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n != 0)
                {
                    if (n % 2 == 0)
                    {
                        even += n;  //Подсчет четных
                    }
                    else
                    {
                        odd += n; //Подсчет нечетных
                    }
                }
                else
                {
                    break;
                }


            }
            Console.WriteLine("Сумма всех нечетных чисел равна: " + odd); //Сумма нечетных
            Console.WriteLine("Сумма всех четных чисел равна: " + even); //Сумма четных

            // б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
            // С этим пока не разобрался (((
            Console.ReadKey();
        }
    }
}
