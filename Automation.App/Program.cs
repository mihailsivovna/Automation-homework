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

            string name;
            Console.Write("Enter your name: ");
            name =Console.ReadLine();
            string surname;
            Console.Write("Enter your surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Nice to meet you," + " " + name + " " + surname);
            Console.ReadLine();



            double a;
            Console.Write("Enter price per 1 dollar: ");
            string input = Console.ReadLine();
            a = Convert.ToDouble(input);
            double b;
            Console.Write("Enter amount: ");
            string input2 = Console.ReadLine();
            b = Convert.ToDouble(input2);
            double c = a * b;
            Console.Write( b + " dollars equal " + c);
            Console.ReadLine();




            int d;
            Console.Write("Введите первое число: ");
            string input3 = Console.ReadLine();
            d = Convert.ToInt32(input3);
            int f;
            Console.Write("Введите второе число: ");
            string input4 = Console.ReadLine();
            f = Convert.ToInt32(input4);
            int e = d / f;
            float h = d % f;
            Console.Write("Неполное частное: " + e + " " + " Oстаток: " + h);
            Console.ReadLine();

        



        }



    }
}
