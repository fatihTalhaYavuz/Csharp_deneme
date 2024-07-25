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
