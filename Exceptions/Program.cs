
using System.Reflection;

namespace Exceptionn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(exception.Message);
            //}
            //HandleEcxeption(() =>
            //{
            //    Find();
            //});

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3,5));
            Console.WriteLine(Topla(4,6));

            Func<int> getRAndom = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);

            };
            Console.WriteLine(getRAndom());
            Func<int> getnumber2 = ()=>new Random().Next(1,100); //Func bu lşkilde de yukardaki gibi de çağırılabilir

        }
        static int Topla(int n, int m ) {
            return n + m;
        }

        private static void HandleEcxeption(Action action)
        {
            try
            {
                action.Invoke();

            }
            catch (Exception exception)//(IndexOutOfRangeException exception)(DivideByZeroException exception)

            {
                Console.WriteLine(exception.Message);
                throw;

            }

            static void Find()
            {
                string[] students = new string[3] { "engin", "derin", "salih" };

                students[3] = "ahmet";
            }
        }
    }
}