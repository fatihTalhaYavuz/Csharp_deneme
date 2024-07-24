
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

        private static void Find()
        {
            string[] students = new string[3] { "engin", "derin", "salih" };

            students[3] = "ahmet";
        }
    }
}