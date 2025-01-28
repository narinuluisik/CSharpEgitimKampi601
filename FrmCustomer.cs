using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;port=5432;Database=CustomerDb; userId=postgres;Password=1234";
        void   GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);

            connection.Open();  
            String query="Select * From Customers";
            var command = new NpgsqlCommand(query, connection);
            var adapter= new NpgsqlDataAdapter(command);
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

        }

         
        private void button1_Click(object sender, EventArgs e)
        {
            GetAllCustomers();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerCity = txtCustomerCity.Text;
            string customerSurname = txtCustomerSurname.Text;   
            int id=int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Set Customers (CustomerName,CustomerSurname,CustomerCity) values(@customerName,@customerSurname,@customerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerName", customerName);
            command.Parameters.AddWithValue("@CustomerSurame", customerSurname);
            command.Parameters.AddWithValue("@CustomerCity", customerCity);
            command.Parameters.AddWithValue("@CustomerId", id);
            MessageBox.Show("  GÜNCELLEME İŞLEMİ BAŞARILI");
            connection.Close();
            GetAllCustomers();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            String query = "Delete From Customers where CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("sİLME İŞLEMİ BAŞARILI");
            connection.Close();
            GetAllCustomers();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            string customerName=txtCustomerName.Text;
            string customerCity=txtCustomerCity.Text;
            string customerSurname=txtCustomerSurname.Text;
            var connection = new NpgsqlConnection(connectionString);

            connection.Open();
            string query = "insert into Customers (CustomerName,CustomerSurname,CustomerCity) values(@customerName,@customerSurname,@customerCity)";

            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerName", customerName);
            command.Parameters.AddWithValue("@CustomerSurame", customerSurname);
            command.Parameters.AddWithValue("@CustomerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
            connection.Close();
            GetAllCustomers();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomerShoppingCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
