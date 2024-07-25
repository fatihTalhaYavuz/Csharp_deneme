using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntitityFremaworkDemo
{
    internal class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; } //tablolarda products arıyor. 

    }
}
