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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string passwordAgain = txtPasswordAgain.Text;

            if(password == passwordAgain)
            {
                TblUsers tblUsers = new TblUsers();
                tblUsers.Username = username;
                tblUsers.Password = password;

                db.TblUsers.Add(tblUsers);
                db.SaveChanges();

                FrmCategory category = new FrmCategory();
                category.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifreler Birbirleriyle Uyuşmuyor!","Hatalı Parola Girdisi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
