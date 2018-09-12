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



            float a = 28.97f;
            int b = 356;
            float c = a * b;
            Console.WriteLine(c);
            Console.ReadKey();


            int d = 59;
            int e = 7;
            int f = 59 / 7;
            int h = 59 % 7;
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.ReadKey();



        }



    }
}
