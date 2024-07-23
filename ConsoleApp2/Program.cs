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
            Add();
            var resultt=Add2(2, 2);
            Console.WriteLine(resultt);
            Console.WriteLine(Add4(1,2,3,4,5,6,7));

          
        }
        static void Add()
        { Console.WriteLine("added"); }

        static int Add2(int number1,  int number2)
        {
            int result;
            return result=number1+number2;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}

