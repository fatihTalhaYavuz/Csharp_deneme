using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection((@"server=(localdb)\mssqllocaldb; initial catalog=ETrade; integrated security=true"));//bağlntı adresi için koddd
        public List<Product> GetAll()
        {
           
            ConnectionControl(_connection);

            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToInt32(reader["UnitPrice"])
                };
                products.Add(product);

            }



            reader.Close();
            _connection.Close();
            return products;
        }

        private static void ConnectionControl(SqlConnection _connection)

        {
         
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();//bağlantı açacağız
            }
        }

        public void Add(Product product)
        {
            ConnectionControl(_connection);
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(Product product)
        {
            ConnectionControl(_connection);
            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice@unitPrice,StockAmount=@stockAmount where Id=@id)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        //public DataTable GetAll2()
        //{
        //    SqlConnection connection = new SqlConnection((@"server=(localdb)\mssqllocaldb; initial catalog=ETrade; integrated security=true"));//bağlntı adresi için kod
        //    if (connection.State == System.Data.ConnectionState.Closed)
        //    {
        //        connection.Open();//bağlantı açacağız
        //    }

        //    SqlCommand command = new SqlCommand("select * from Products", connection);

        //    SqlDataReader reader = command.ExecuteReader();

        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);
        //    reader.Close();
        //    connection.Close();
        //    return dataTable;
        //}

    }
}
