using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisit_Card
{
    

    class Program
    {
        static void Print(string hello, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(hello);
        }
        static void Main(string[] args)
        {
            Print("Привет, меня зовут Николай Ничуговский, я живу в городе Екатеринбург", 30, 10);

            Console.ReadKey();
                       
        }
    }
}
