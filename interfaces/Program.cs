
using interfaces;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICustmerDal[] customerDals = new ICustmerDal[2] {
            new SqlServerCustomerDAl(),
            new OracleCustemerDal(),
            };

        }
    }
    interface IPerson
    {
        string ID { get; set; }
        int FirstName { get; set; }
        int LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Departmant { get; set; }
    }


}