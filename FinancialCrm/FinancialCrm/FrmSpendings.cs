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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void harcamalariGetir()
        {

            var values = db.TblSpendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.TblCategories.CategoryName,
            }).ToList();
            dataGridView1.DataSource = values;

            var value = db.TblCategories.Select(x => new
            {
                Value = x.CategoryId,
                Display = x.CategoryName,
            }).ToList();

            cmbSpendCategory.DataSource = value;
            cmbSpendCategory.DisplayMember = "Display";
            cmbSpendCategory.ValueMember = "Value";
        }

        private void btnAddSpend_Click(object sender, EventArgs e)
        {
            string spendName = txtSpendName.Text;
            decimal spendPrice = decimal.Parse(txtSpendAmount.Text);
            DateTime spendDate = DateTime.Parse(dateTimePicker1.Text);
            int spendCategoriId = int.Parse(cmbSpendCategory.SelectedValue.ToString());

            

            TblSpendings tblSpendings = new TblSpendings();


            tblSpendings.SpendingTitle = spendName;
            tblSpendings.SpendingAmount = spendPrice;
            tblSpendings.SpendingDate = spendDate;
            tblSpendings.CategoryId = spendCategoriId;


            db.TblSpendings.Add(tblSpendings);
            db.SaveChanges();

            MessageBox.Show("Harcama Ekleme İşlemi Tamamlandı!", "Harcama İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            harcamalariGetir();
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            harcamalariGetir();
        }

        private void btnSpendUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendId.Text);
            
            string spendingTitle = txtSpendName.Text;
            decimal spendingAmount = decimal.Parse(txtSpendAmount.Text);
            DateTime spendingDateTime = DateTime.Parse(dateTimePicker1.Text);
            int spendingCategoryId = int.Parse(cmbSpendCategory.SelectedValue.ToString());

            var values = db.TblSpendings.Find(id);

            values.SpendingTitle = spendingTitle;
            values.SpendingAmount = spendingAmount;
            values.SpendingDate = spendingDateTime;
            values.CategoryId = spendingCategoryId;

            db.SaveChanges();

            MessageBox.Show("Harcama Güncelleme İşlemi Tamamlandı!", "Harcama İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            harcamalariGetir();

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnSpendDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendId.Text);

            var removeValues = db.TblSpendings.Find(id);
            db.TblSpendings.Remove(removeValues);

            db.SaveChanges();

            MessageBox.Show("Harcama Silme İşlemi Tamamlandı!", "Harcama İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            harcamalariGetir();

        }

        private void btnSpendList_Click(object sender, EventArgs e)
        {
            harcamalariGetir();
        }



        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
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

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }
    }
}
