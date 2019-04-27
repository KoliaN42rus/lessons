using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex  //Ничуговский Николай. Дописать класс Complex, добавив методы вычитания и произведения чисел
{
    struct Complex
    {
        public double im;
        public double re;
        public Complex(double Re, double Im)
        {
            re = Re;
            im = Im;
        }

        //Сложение
        public Complex Plus(Complex x2)
        {
            Complex result = new Complex
            {
                im = x2.im + this.im,
                re = x2.re + this.re
            };
             
                return result;
        }

            public string stringPlus()
            {
                return re + "+" + im + "i";
            }



        //Вычитание
        public Complex Minus(Complex y2)
        {
            Complex result = new Complex
            {
                im = y2.im + this.im,
                re = y2.re + this.re
            };

            return result;
        }

        public string stringMinus()
        {
            return re + "-" + im + "i";
        }


         //Умножение
        public Complex Multi(Complex z2)
        {
            Complex result = new Complex
            {
                im = z2.im * this.im,
                re = z2.re * this.re
            };

            return result;
        }

        public string stringMulti()
        {
            return re + "+" + im + "i";
        }


        class Program
        {
            static void Main(string[] args)
            {

                Complex cmp1 = new Complex(1, 2);
                Console.WriteLine(cmp1.stringPlus());       //Первое число
                Complex cmp2 = new Complex(3, 4);
                Console.WriteLine(cmp2.stringPlus());       //Второе число

                Complex resPlus = cmp1.Plus(cmp2);          //Вывод сложения
                Console.WriteLine(resPlus.stringPlus());

                Complex resMinus = cmp1.Minus(cmp2);        //Вывод вычитания
                Console.WriteLine(resMinus.stringMinus());

                Complex resMulti = cmp1.Multi(cmp2);        //Вывод умножения
                Console.WriteLine(resMulti.stringMulti());
                                                                                 
                Console.ReadKey();
            }


        }

       
    }


}

