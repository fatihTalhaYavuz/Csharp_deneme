using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitityFremaworkDemo
{
    internal class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                return context.Products.ToList();

            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();

            }
        }
        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList(); //select*from Products where UnitPrice>=price sorgusunu atar

            }
        }
        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList(); //select*from Products where UnitPrice >= min && UnitPrice<=max sorgusunu atar

            }
        }
        public Product GetById(int id)//tek bir ürün getireceği için liste değil de id, bana id ver ben sana id veriyim
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                var result = context.Products.FirstOrDefault(p => p.Id == id); //bu id ye bağlı olan ilk kaydı getir ya da bulamzsan null getirir.
                return result; // SingleOrDefault kullanırsak mesela 3 tane ayı şey var yazdırmıyor ve hata mesajı fırlatıyor.

            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
               context.Products.Add(product);//contexteki producsa ekle
                context.SaveChanges();//yaptığımız değişiklikleri veritabanına yaz

            }

        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                var entity = context.Entry(product);//Gönderdiğimiz product2ı veritabanındaki product ile eşitliyor
                entity.State = System.Data.Entity.EntityState.Modified;//Durmu da güncellendi diye bildiriyor 
                context.SaveChanges();//yaptığımız değişiklikleri veritabanına yaz

            }

        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                var entity = context.Entry(product);//Gönderdiğimiz product 2yi veritabanındaki product ile eşitliyor
                entity.State = System.Data.Entity.EntityState.Deleted;//Durmu da güncellendi diye bildiriyor 
                context.SaveChanges();//yaptığımız değişiklikleri veritabanına yaz

            }

        }
    }
}
