using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давай знакомиться! Заполни небольшую анкету");
            Console.WriteLine("Как тебя зовут?");
                 string name = Console.ReadLine();
            Console.WriteLine("Какая у тебя фамилия?");
                 string surname = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет?");
                 string age = Console.ReadLine();
            Console.WriteLine("Какой у тебя рост (см)?");
                 string height = Console.ReadLine();
                 double h = double.Parse(height); 
            Console.WriteLine("Как у тебя вес (кг)?");
                 string mass = Console.ReadLine();
                 double m = double.Parse(mass);

            Console.Write("Будем знакомы, " + name + " " + surname + "!");
            Console.WriteLine(" Твой возраст - " + age + ", твой рост - " + h + ", твой вес - " + m);

                 double massIndex = m/ ((h / 100) * (h / 100));
            Console.WriteLine("Индекс твоей массы равен {0:F}", massIndex);


            Console.ReadKey();
        }
    }
}
