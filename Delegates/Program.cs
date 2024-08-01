namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1, int number2);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello");

            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);


        }
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
    public class Matematik
    {
        public int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
