using System.Collections;

namespace Collecitons
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();
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