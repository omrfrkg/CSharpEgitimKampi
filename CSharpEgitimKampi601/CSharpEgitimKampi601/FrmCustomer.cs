using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=189061";

        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customer";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert Into Customer(CustomerName,CustomerSurname,CustomerCity) Values(@customerName,@customerSurname,@customerCity)";
            var command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@customerName",customerName);
            command.Parameters.AddWithValue("@customerSurname",customerSurname);
            command.Parameters.AddWithValue("@customerCity",customerCity);
            command.ExecuteNonQuery();

            MessageBox.Show("Ekleme İşlemi Başarılı!");
            connection.Close() ;
            GetAllCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Customer Where CustomerId = @customerId";
            var command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@customerId",id);
            command.ExecuteNonQuery();

            MessageBox.Show("Silme İşlemi Başarılı!");
            connection.Close();
            GetAllCustomers();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            int id = int.Parse(txtCustomerId.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Customer Set CustomerName = @customerName, CustomerSurname = @customerSurname, CustomerCity=@customerCity Where CustomerId = @customerId";
            var command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("customerName",customerName);
            command.Parameters.AddWithValue("customerSurname",customerSurname);
            command.Parameters.AddWithValue("customerCity",customerCity);
            command.Parameters.AddWithValue("customerId",id);
            command.ExecuteNonQuery();

            MessageBox.Show("Güncelleme İşlemi Başarılı!");
            connection.Close();
            GetAllCustomers();
        }
    }
}
