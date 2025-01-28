using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations customerOperations = new CustomerOperations();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomeBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomeShopppingCount = int.Parse(txtCustomerShoppingCount.Text),


            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Müşteri Ekleme İşlemi Başarılı");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource= customers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string CustomerId= txtCustomerId.Text;
            customerOperations.DeleteCustomer(CustomerId);
            MessageBox.Show("Müşteri başarıyla Silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var updatedCustomer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomeBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomeShopppingCount = int.Parse(txtCustomerShoppingCount.Text),

            };
            customerOperations.UpdateCustomer(updatedCustomer);
            MessageBox.Show("Müşteri Güncelleme İşlemi Başarılı");

        }
    }
}
