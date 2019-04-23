using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberCount
{
    class Program //Николай Ничуговский
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько чисел, а я посчитаю сумму четных и нечетных из них.");
            Console.WriteLine("Чтобы вывести результат, после ввода основных чисел, введите 0");
            int odd = 0; int even = 0;
            while(true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n != 0)
                {
                    if (n % 2 == 0)
                    {
                        even += n;
                    }
                    else
                    {
                        odd += n;
                    }
                        
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Сумма всех нечетных чисел равна: " + odd);
            Console.WriteLine("Сумма всех четных чисел равна: " + even);


            Console.ReadKey();
        }
    }
}
