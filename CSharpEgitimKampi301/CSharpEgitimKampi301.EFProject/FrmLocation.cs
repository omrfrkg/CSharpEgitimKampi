using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblLocation
                   .Select(x => new
                   {
                       x.LocationId,
                       x.City,
                       x.Country,
                       x.Capacity,
                       x.Price,
                       x.DayNight,
                       Guide = x.TblGuide.GuideName + " " + x.TblGuide.GuideSurname,
                   })
                   .ToList(); ;
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLocation location = new TblLocation();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());

            db.TblLocation.Add(location);
            db.SaveChanges();

            MessageBox.Show("Ekleme İşlemi Başarıyla Tamamlandı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.TblLocation.Find(id);

            db.TblLocation.Remove(deletedValue);
            db.SaveChanges();

            MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı!");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.TblLocation.Find(id);

            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());

            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı!");


        }
    }
}
