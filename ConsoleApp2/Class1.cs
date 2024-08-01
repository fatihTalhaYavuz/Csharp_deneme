using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be carefull!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

    }
}
