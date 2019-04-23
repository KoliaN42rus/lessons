using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCount
{
    class Program //Николай Ничуговский
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, а я скажу, сколько в нем цифр:");
            string n = Console.ReadLine();
            Console.WriteLine("В этом числе " +n.Length + " цифр");
            Console.ReadKey(); //Я понимаю, что программа выведет и количество букв, 
            //но здравомыслящий человек введет цифры, если его попросят)) поэтому решение примитивное)
        }
    }
}
