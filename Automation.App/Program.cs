using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите год: ");
            string year = Console.ReadLine();
            int n = Convert.ToInt32(year);
            int m;
            m = (n % 4);
            if (m == 0)
                Console.WriteLine($"{year} - год высокосный ");
            else
                Console.WriteLine($"{year} - год невысокосный ");
            Console.ReadLine();



            Console.Write("Введите день недели: ");
            string week = Console.ReadLine();

            switch (week)
            {
                case "Понедельник":
                    Console.WriteLine($"{week} - рабочий день недели");
                    break;

                case "Вторник":
                    Console.WriteLine($"{week} - рабочий день недели");
                    break;
                case "Среда":
                    Console.WriteLine($"{week} - рабочий день недели");
                    break;
                case "Четверг":
                    Console.WriteLine($"{week} - рабочий день недели");
                    break;
                case "Пятница":
                    Console.WriteLine($"{week} - рабочий день недели");
                    break;
                case "Суббота":
                    Console.WriteLine($"{week} - выходной день недели");
                    break;
                case "Воскресение":
                    Console.WriteLine($"{week} - выходной день недели");
                    break;
            }

            Console.Write("Введите размер: ");
            string size = Console.ReadLine();
            int a = Convert.ToInt32(size);


            if (a <= 31)
                Console.WriteLine("xxs");
            else if (a <= 32)
                Console.WriteLine("xs");
            else if (a <= 36)
                Console.WriteLine("s");
            else if (a <= 40)
                Console.WriteLine("m");
            else if (a <= 44)
                Console.WriteLine("l");
            else if (a <= 48)
                Console.WriteLine("xl");
            else if (a <= 50)
                Console.WriteLine("2xl");
            else if (a > 50)
                Console.WriteLine("Неизвестный размер");

            Console.ReadLine();
        }
    }
}

