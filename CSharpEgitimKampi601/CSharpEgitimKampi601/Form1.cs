﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations customerOperations = new CustomerOperations();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
            };

            customerOperations.AddCustomer(customer);

            MessageBox.Show("Müşteri Ekleme İşlemi Başarıyla Tamamlandı!","İşlem Uyarısı!",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource = customers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);

            MessageBox.Show("Müşteri Silme İşlemi Başarıyla Tamamlandı!", "İşlem Uyarısı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;

            var updateCustomer = new Customer
            {
                CustomerId = customerId,
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text)
            };

            customerOperations.UpdateCustomer(updateCustomer);

            MessageBox.Show("Müşteri Güncelleme İşlemi Başarıyla Tamamlandı!", "İşlem Uyarısı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            Customer customer = customerOperations.GetCustomerById(id);
            dataGridView1.DataSource = new List<Customer> { customer };
        }
    }
}
