using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{


    static void Main(String[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();
 
        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.Name = "Test";
        customer.Address = "asaafad";

        Customer customer2 = new Customer()
        {
            Address = customer.Address,
            City = "veli",
        };
        Console.WriteLine(customer.Name);



    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("added");
        }
        public void Update()
        {
            Console.WriteLine("updated");
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }



    }
}
