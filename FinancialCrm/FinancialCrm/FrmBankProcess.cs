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
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void TblBankProcess_Load(object sender, EventArgs e)
        {
            //Banka Hareketleri
            var bankProcess = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(1).FirstOrDefault();
            lblBankProcess.Text = bankProcess.Description + " " + bankProcess.Amount + " " + bankProcess.ProcessDate;

            var bankProcess2 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate;

            var bankProcess6 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(6).Skip(5).FirstOrDefault();
            lblBankProcess6.Text = bankProcess6.Description + " " + bankProcess6.Amount + " " + bankProcess6.ProcessDate;

            var bankProcess7 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(7).Skip(6).FirstOrDefault();
            lblBankProcess7.Text = bankProcess7.Description + " " + bankProcess7.Amount + " " + bankProcess7.ProcessDate;

            var bankProcess8 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(8).Skip(7).FirstOrDefault();
            lblBankProcess8.Text = bankProcess8.Description + " " + bankProcess8.Amount + " " + bankProcess8.ProcessDate;

            var bankProcess9 = db.TblBankProcesses.OrderByDescending(x => x.ProcessDate).Take(9).Skip(8).FirstOrDefault();
            lblBankProcess9.Text = bankProcess9.Description + " " + bankProcess9.Amount + " " + bankProcess9.ProcessDate;
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

        private void btnBillingForm_Click(object sender, EventArgs e)
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

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
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
