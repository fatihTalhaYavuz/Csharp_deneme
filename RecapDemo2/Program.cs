using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
        }
        class CustomerManager
        {
            public void Add()
            {
                Logger logger = new Logger();
                logger.Log();
                Console.WriteLine("Customer Added!");
            }
        }
        class Logger : ILogger   
        {
            public void Log()
            {
                Console.WriteLine("Logged"); 
            }
    }
    interface ILogger
    {d
        void Log();
    }
    
    }
}
