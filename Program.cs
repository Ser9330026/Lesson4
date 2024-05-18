using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 9, b = 10;
            if (a == b)
            {
                Console.WriteLine("Равно");
            } else {
                Console.WriteLine((b < a) ? "Yes" : "No");
            }

            string login = "Admin";
            string password = "Sergey80";

            Console.WriteLine("Введите логин:");
            string log = Console.ReadLine();

            if (log == login)
            {
                Console.WriteLine("Введите пароль: ");
                string pass = Console.ReadLine();
                if (pass == password)
                {
                    Console.WriteLine("Логин и пароль правильные!!!");
                } else
                {
                    Console.WriteLine("Пароль не правильный!!!");
                }
            } else {
                Console.WriteLine("Логин не правильный!!!");
            }
            int aa = 5, bb = 7, cc = 0;
            cc = (aa > bb) ? aa : bb;
            Console.WriteLine(cc);

            int aaa = 1, bbb = 2, ccc = -5, max = 0;
            max = (aaa > bbb) ? ccc = aaa : ccc = bbb;
            Console.WriteLine(max);
            Console.WriteLine(ccc);

            string @string = "hello";
            Console.Write("Введите логин: ");
            string log11 = Console.ReadLine();

            @string += log11 == "Admin" ? " Administrator " : " User ";

            Console.WriteLine(@string);

            int num1 = 4;
            double numD = 5.4f;
            int max1 = (int)((num1 > numD) ? num1 : numD);
            Console.WriteLine(max1);

            int quantity = 9;
            double price = 100;
            double discount = 0.75;
            double cost;

            cost = quantity >= 10 ? quantity * price * discount : quantity * price;
            Console.WriteLine("Общая стоимость составляет {0} рублей", cost);

            int coordX = 10;
            int coordY = -20;

            string cvadrant = (coordX > 0) ?
                (coordY > 0 ? "Первый квадрант" : "Четвертый квадрант") :
                (coordY > 0 ? "Второй квадрант" : "Третий квадрант");
            Console.WriteLine(cvadrant);

            Console.Write("Введите число от 1 до 2: ");
            string value = Console.ReadLine();

            int val222 = Convert.ToInt32(value);    

            switch (val222)
            {
                case 1:
                    {
                        Console.WriteLine(value); break;
                    }
                case 2:
                    {
                        Console.WriteLine(value); break;
                    }
            
            default:
                {
                Console.WriteLine("No");
                break;
                }
            }

            Console.Write("Введите день недели от 1 до 7: ");
            string day = Console.ReadLine();
            
            int days = Convert.ToInt32(day);

            switch(days)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        Console.WriteLine("Рабочие дни!!!");
                        break;
                    }
                case 6:
                case 7:
                    {
                        Console.WriteLine("Выходные дни дни!!!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No");
                        break;
                    }

            }


        } 
    }
}
