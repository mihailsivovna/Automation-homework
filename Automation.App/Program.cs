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

            GetNumber();
            Console.ReadLine();

        }


        public static int GetNumber()
        {

            int x=0;
            while (true)
            if(x == 0)
            


                try
                {
                    Console.Write("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Write(number + " - число ");
                    break;
                    

                }
                catch (FormatException)

                {
                    Console.WriteLine("Не является числом");
                }

            return x;

        }



    }
}

