using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.App
{
    class Program
    {
        static void Main(string[] args)
        {



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
            string input = Console.ReadLine();
            int a = Convert.ToInt32(input);
            int b = Convert.ToInt32(input);
            int c = Convert.ToInt32(input);
            int d = Convert.ToInt32(input);
            int h = Convert.ToInt32(input);
            int g = Convert.ToInt32(input);
            int j = Convert.ToInt32(input);
            int k = Convert.ToInt32(input);




            if (a <= 31)
                Console.WriteLine("xxs");
            else if (b > 31 && b <= 32)
                Console.WriteLine("xs");
            else if (c > 32  && c <= 36)
                Console.WriteLine("s");
            else if (d > 36 && d <= 40)
                Console.WriteLine("m");
            else if (h > 40 && h <= 44)
                Console.WriteLine("l");
            else if (g > 44 && g <=48)
                Console.WriteLine("xl");
            else if (j > 48 && j <= 50)
                Console.WriteLine("2xl");
            else if (k > 50)
                    Console.WriteLine("Неизвестный размер");
           
            Console.ReadLine();



            Console.Write("Введите год: ");
            string input3 = Console.ReadLine();
            int m = Convert.ToInt32(input3);
            int n = Convert.ToInt32(input3);
            m = (n % 4);

            if (m == 0)
                Console.WriteLine($"{input3} - год высокосный ");
            else
                Console.WriteLine($"{input3} - год невысокосный ");
            Console.ReadLine();
        



















        }
}
}
