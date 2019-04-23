using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassCheck
{
    class Program //Николай Ничуговский
    {
        static void Main(string[] args)
        {
            string log = "root"; string pass = "GeekBrains"; int tryCount = 0;

            do
            {
                Console.WriteLine("Пожалуйста, авторизуйтесь в системе. Ваш логин: ");
                string logCheck = Console.ReadLine();

                Console.WriteLine("Ваш пароль: ");
                string passCheck = Console.ReadLine();

                    if (log == logCheck && pass == passCheck)
                    {

                        Console.WriteLine("Добро пожаловать!");
                        Console.ReadLine();
                        break;
                    }
                    Console.WriteLine("Неверно введен логин или пароль, осталось попыток: " + (2-tryCount)+ ". Нажмите ENTER");
                    Console.ReadLine();
                    tryCount++;

            } while (tryCount<=2);
            Console.WriteLine("Вы превысили количество попыток. \nВосстановите логин и пароль у администратора и приходите позже.");

            Console.ReadKey();
        }

    }
}
