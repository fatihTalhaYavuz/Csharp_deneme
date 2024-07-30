using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");// Araçlarla birlikte liste oluştur, metodu generick yapıda yaptık, Ankarayı strik türünden tuttutk

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Engin" }, new Customer { FirstName = "Ali" });

            foreach (var costumer in result2) {
                Console.WriteLine(costumer.FirstName);
            }
        }
        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            { //çalışacağım tipte değerler istiyorum params kullanırız
                return new List<T>(items);
            }
        }
        class Product
        {

        }
        
        class Customer
        {
            public string FirstName { get; set; }

        }

        interface ICustomertDal : IRepository<Student>
        {

        }
        interface IStudentDal : IRepository<Student>
        {

        }
        class Student:IEntity
        {

        }
        interface IEntity
        {

        }
        interface IRepository<T> where T : class, IEntity, new()//class referans tipi demektir, üstteki iki örenk, referenas tipi olarak sadece Student
        {//class veri tipi olmalo, IENtitiy intehrit edilmeli ve newlenebilmeli
            //T:struct yazsaydık int gibi değer isterdi
            List<T> GetAll();
            Product Get(int id);
            void Add(T entity); //bana bi  ürün ver ekliyim
            void Delete(T entity);
            void Update(T entity);

        }
        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }

        }
        class CustomerDal : ICustomertDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
    }
}