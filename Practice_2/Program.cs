using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //         вычисления значения функции y = 7x ^ 2 - 3x + 4  при любом значении x;
            int y;
            Console.WriteLine("Введите целое число Х - ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("В заданном уравнении - y = 7x ^ 2 - 3x + 4 ");
            y = 7 * (x * x) - 3 * x + 4;
            Console.WriteLine("Число y = " + y);

            //         Дан радиус окружности.Найти длину окружности и площадь круга.
            Console.WriteLine("Введите радиус окружности ");
            double r = double.Parse(Console.ReadLine());
            double l = r * 2;
            double len = 3.14 * l;
            l = r * r;
            double s = 3.14 * l;
            Console.WriteLine("Длина окружности равна - " + len);
            Console.WriteLine("Площадь окружности равна - " + s);

            // Дано расстояние в сантиметрах. Найти число полных метров в нем.
            Console.WriteLine("Введите расстояние в сантиметрах ");
            double k = double.Parse(Console.ReadLine());
            int z = Convert.ToInt32(k) / 100;
            if (z > 1)
                Console.WriteLine("В вашем числе полных метров - " + z);
            else
                Console.WriteLine("Ваше число меньше метра ");


            // С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период?
            int c = 234/7;
            Console.WriteLine("С некоторого момента прошло полных недель - " + c);

            //Дано двузначное число. Найти:
            //         число десятков в нем;
            //         число единиц в нем;
            //         сумму его цифр;
            //         произведение его цифр
            //         Дано четырехзначное число. Найти:
            //         сумму его цифр;
            //         произведение его цифр.
            Console.WriteLine("Введите целое двузначное число - ");
            int m = int.Parse(Console.ReadLine());
            int d = m / 10;
            int e = m % 10;
            Console.WriteLine("В вашем числе " + d + " десятков  и  " + e + "   единиц");
            Console.WriteLine("сумма его цифр равна " + (d + e));
            Console.WriteLine("\n");
            Console.WriteLine("Введите целое четырехзначное число - ");
            int m2 = int.Parse(Console.ReadLine());
            int a = m2 % 10;
            int b = (m2 / 10) % 10;
            int q = (m2 / 100) % 10;
            int g = m2 / 1000;
            Console.WriteLine("сумма его цифр равна " + (a + b + q + g));
            Console.WriteLine("произведение его цифр равна " + (a * b * q * g));

            // В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному 
            //при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456.Найти число x.
            Console.WriteLine("Ваше число x равно  - " + 465);

            // Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
            //         не X и не Y;
            //         X или(не X и Y);
            //         (не X и Y) или Y.
            bool X = true;
            bool Y = true;
            Console.WriteLine("X = true");
            Console.WriteLine("Y = true");

            bool Z = !X & !Y;
            Console.WriteLine("не X и не Y = ");
            Console.WriteLine(Z +"\n");

            Z = X || (!X & Y);
            Console.WriteLine("X или(не X и Y) = ");
            Console.WriteLine(Z + "\n");

            Z = (!X & Y) || Y;
            Console.WriteLine("(не X и Y) или Y = ");
            Console.WriteLine(Z + "\n");
            Console.WriteLine("\n\n");
            
            Y = false;
            Console.WriteLine("X = true");
            Console.WriteLine("Y = false");

            Z = !X & !Y;
            Console.WriteLine("не X и не Y = ");
            Console.WriteLine(Z + "\n");

            Z = X || (!X & Y);
            Console.WriteLine("X или(не X и Y) = ");
            Console.WriteLine(Z + "\n");

            Z = (!X & Y) || Y;
            Console.WriteLine("(не X и Y) или Y = ");
            Console.WriteLine(Z + "\n");
            Console.WriteLine("\n\n");
            X = false;
            Y = true;
            Console.WriteLine("X = false");
            Console.WriteLine("Y = true");

            Z = !X & !Y;
            Console.WriteLine("не X и не Y = ");
            Console.WriteLine(Z + "\n");

            Z = X || (!X & Y);
            Console.WriteLine("X или(не X и Y) = ");
            Console.WriteLine(Z + "\n");

            Z = (!X & Y) || Y;
            Console.WriteLine("(не X и Y) или Y = ");
            Console.WriteLine(Z + "\n");
            Console.WriteLine("\n\n");
            Y = false;
            Console.WriteLine("X = false");
            Console.WriteLine("Y = false");

            Z = !X & !Y;
            Console.WriteLine("не X и не Y = ");
            Console.WriteLine(Z + "\n");

            Z = X || (!X & Y);
            Console.WriteLine("X или(не X и Y) = ");
            Console.WriteLine(Z + "\n");

            Z = (!X & Y) || Y;
            Console.WriteLine("(не X и Y) или Y = ");
            Console.WriteLine(Z + "\n");
            Console.WriteLine("\n\n");
        }
    }
}
