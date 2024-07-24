using System.Collections;

namespace Collecitons
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();
            //List();
            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");   
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "VEli" });
            customers.Add(new Customer
            {
                Id = 2,
                Name = "Veli"
            });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            var count = customers.Count;
            var customer1 = new Customer { Id = 3, Name = "salih" };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]{
                new Customer { Id = 4, Name="djalks" },
                new Customer { Id = 5, Name="aişe" }

            });
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Maraş");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
    }
}