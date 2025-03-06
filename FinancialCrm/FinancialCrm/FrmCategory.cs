using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        void kategoriGetir()
        {
            var value = db.TblCategories.Select(x => new
            {
               x.CategoryId,
               x.CategoryName,
            }).ToList();
            dataGridView1.DataSource = value;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            TblCategories tblCategories = new TblCategories();
            tblCategories.CategoryName = categoryName;
            db.TblCategories.Add(tblCategories);
            db.SaveChanges();

            MessageBox.Show("Kategori Ekleme İşlemi Başarılı","Kategori İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Information);

            kategoriGetir();

        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.TblCategories.Find(id);
            db.TblCategories.Remove(removeValue);
            db.SaveChanges() ;

            MessageBox.Show("Kategori Silme İşlemi Başarılı!","Kategori İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Information);
            kategoriGetir();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;

            var values = db.TblCategories.Find(id);

            values.CategoryName = categoryName;
            db.SaveChanges();

            MessageBox.Show("Kategori Güncelleme İşlemi Başarılı!", "Kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            kategoriGetir();

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
