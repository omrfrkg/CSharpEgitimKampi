using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi501.ConnectionString;
using CSharpEgitimKampi501.Dtos;
using Dapper;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E9NIK52;initial Catalog = EgitimKampi501Db;integrated security=true");


        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * From TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into TblProduct (ProductName, ProductStock, ProductPrice, ProductCategory) values(@productName,@productStock,@productPrice,@productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName",txtProductName.Text);
            parameters.Add("@productStock",txtProductStock.Text);
            parameters.Add("@productPrice",txtProductPrice.Text);
            parameters.Add("@productCategory",txtProductCategory.Text);
            await connection.ExecuteAsync(query,parameters);

            MessageBox.Show("Yeni Kitap Ekleme İşlemi Başarılı!");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From TblProduct Where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query,parameters);

            MessageBox.Show("Kitap Silme İşlemi Başarılı!");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice, ProductStock = @productStock, ProductCategory = @productCategory Where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName",txtProductName.Text);
            parameters.Add("@productStock",txtProductStock.Text);
            parameters.Add("@productPrice",txtProductPrice.Text);
            parameters.Add("@productCategory",txtProductCategory.Text);
            parameters.Add("@productId",txtProductId.Text);
            await connection.ExecuteAsync(query,parameters);

            MessageBox.Show("Kitap Güncelleme İşlemi Başarıyla Tamamlandı!","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Toplam Kitap Sayısı
            string query = "Select Count(*) From TblProduct";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query);
            lblTotalProductCount.Text = productTotalCount.ToString();

            //En Pahalı Kitap
            string query2 = "Select TOP 1 ProductName From TblProduct ORDER BY ProductPrice DESC";
            var maxProductPriceName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxProductPriceName.Text = maxProductPriceName;

            //Kaç Farklı Kitap Türü Var
            string query3 = "Select COUNT(DISTINCT(ProductCategory)) From TblProduct";
            var productDisctinctCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblProductDistinctCount.Text = productDisctinctCount.ToString();
        }
    }
}
