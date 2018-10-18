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

            Page page = new Page(null);
            
            page.Login("name","login");
            Console.ReadLine();
        }


    }
}

