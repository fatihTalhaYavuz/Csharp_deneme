using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer customer = new Customer { Id = 1, LastName = "Engin", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

        }
    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
        
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method ")]
        public void Add(Customer customer)
        {
            
            Console.WriteLine("{0}, {1}, {2}, {3} added!",customer.Id,customer.FirstName,customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]// class olsaydı, RequiredProperty sadece classlar üzerine eklenebilirdi
    //Property methodlar için kullacağımız için. | ile yazımıza devam edebiliriz işte sadece class sadece method gibi ucuna ekleme yapabiliriz


    class RequiredPropertyAttribute : Attribute { } //Zorunlu olarak o değerleri sisteme girmesi lazım zorunluluğunu veriyor

    class ToTableAttribute: Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }

    }

}
