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

            Console.WriteLine("До числа: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int fib1 = 1;
            Console.Write("{0} ", fib1);
            int fib2 = 1;
            Console.Write("{0} ", fib2);
            int sum = 0;

            while (number >= sum)
            {
                sum = fib1 + fib2;
                Console.Write("{0} ", sum);

                fib1 = fib2;
                fib2 = sum;
            }
            Console.ReadLine();


            {
                for (int h = 0; h <= 100; h++)



                {

                    if (h % 3 == 0)
                        Console.WriteLine("Фаз");
                    if (h % 5 == 0)
                        Console.WriteLine("Баз");
                    if (h % 3 == 1 & h % 5 == 1)
                        Console.WriteLine("ФазБаз");


                }
                Console.ReadLine();



                {
                    string username = "name";
                    string password = "password";

                    var k = 0;

                    do
                    {
                        if (k == 5)
                        {
                            Console.WriteLine(" Аккаунт заблокирован. Повторите попытку позже ");
                            break;
                        }

                        Console.Write("Введите логин: ");
                        var name = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        var pass = Console.ReadLine();

                        if (username == name && password == pass)
                        {
                            Console.WriteLine("Успешный вход");
                            break;
                        }

                        if (username != name || password != pass)
                        {
                            Console.WriteLine("Неправильный логин или пароль");
                        }

                        Console.WriteLine();
                        k++;

                    } while (k <= 5);

                    Console.ReadLine();
                }

            }

        }
    }
}



    


               

                
        

    
    



            

            
            
    












            


   






        
    
