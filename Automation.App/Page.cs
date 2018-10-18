using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.App
{
    public class Page
    {
     
        string url;
        bool state;

        public Page(string urlPage)
        {
            url = urlPage;
        }
        public void Open()
        {
            Console.WriteLine(url);
        }

        public void Login(string name, string login)
        {
          if (name== "name" && login == "login")
            {
            state = true;
            Console.WriteLine("Успешный вход");
            }
            else
            {
                state = false;
                Console.WriteLine("Неверный логин или пароль");
            }
        }
    }

        
}
