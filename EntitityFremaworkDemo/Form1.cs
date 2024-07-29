using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EntitityFremaworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productDal.GetAll();
        }

        private void tbxNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product { Name = tbxNameUpdate.Text,
            UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
            StockAmount = Convert.ToInt32(tbxStockAmount.Text)});
            LoadProducts();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),

            }); 
            LoadProducts();
            MessageBox.Show("updateddd");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
           
        }
        private void SearchProducts(String key)
        {
            var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList(); //biz arama butonunu önce hepsini küçülttük sonra arattık
            //bu sayede l yazınca "L ve l" olanların hepsini alıyor.
            
            dgwProduct.DataSource = result;
        }
        public List<Product> GetByName()
        {
            using (ETradeContext context = new ETradeContext())//bellekte çok yer kaplar, app.config içindekki Connecting string içinden bağlantı kuracak.
                                                               // Using kullanınca garbage kullanmaya gerk kalmadan kullandıktna sonra direkt çöpe atılması zorluyor.
            {
                return context.Products.ToList();

            }
        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}
