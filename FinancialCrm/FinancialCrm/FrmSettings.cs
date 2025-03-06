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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int id = SessionManager.AktifKullaniciId;

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var value = db.TblUsers.Find(id);
            lblTitle.Text = "Hoşgeldin " + value.Username;
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string passwordAgain = txtPasswordAgain.Text;

            if (password == passwordAgain && password != string.Empty &&  passwordAgain != string.Empty) {
                var value = db.TblUsers.Find(id);
                value.Password = password;
                db.SaveChanges();

                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Formları Hatasız Doldurunuz!","Geçersiz Giriş",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
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

        private void btnBanksProcessForm_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
