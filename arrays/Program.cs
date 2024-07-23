using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[] { "Ali", "Veli", "Efe" };
            string[] students2 = { "alis", "velis", "efes" };

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        
        }
    } 
}

