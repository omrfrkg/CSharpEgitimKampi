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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db =new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            //Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.TblLocation.Count().ToString();

            //Toplam Kapasite
            lblSumCapacity.Text = db.TblLocation.Sum(x => x.Capacity).ToString();

            //Toplam Rehber Sayısı
            lblGuideCount.Text = db.TblGuide.Count().ToString();

            //Ortalama Kapasite
            lblAvgCapacity.Text = db.TblLocation.Average(x => x.Capacity).ToString();

            //Ortalama Tur Fiyatı  
            lblAvgLocationPrice.Text = String.Format("{0:#,0.00}", db.TblLocation.Average(x => x.Price)).ToString();

            /*
             Açıklama:
                {0} → İlk parametreyi temsil eder (burada db.TblLocation.Average(x => x.Price) sonucu).
                # → Gerektiğinde sayı gösterilir, ancak sıfırsa gösterilmez.
                , → Binlik ayıracı olarak kullanılır (örneğin, 1.234 veya 12.345 gibi).
                0.00 → Ondalık basamakları zorunlu kılar. Eğer sayı 2 ondalık basamaktan azsa, eksik olanlar 0 ile tamamlanır.
             */

            // Eklenen Son Ülke
            int lastCountryId = db.TblLocation.Max(x => x.LocationId);
            lblLastCountryName.Text = db.TblLocation.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            //Kapadokya Tur Kapasitesi
            lblCappadociaLocationCapacity.Text = db.TblLocation.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            //Türkiye Turları Ortalama Kapasite
            lblTurkeyAvgCapacity.Text = db.TblLocation.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            //Roma Gezi Rehberi
            var romeGuideId = db.TblLocation.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.TblGuide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " "+ y.GuideSurname).FirstOrDefault().ToString();

            //En Yüksek Kapasiteli Tur
            var maxCapacity = db.TblLocation.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.TblLocation.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            //En Pahalı Tur
            var maxPrice = db.TblLocation.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.TblLocation.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            //Ayşgeül Çınar Tur Sayısı
            var aysegulKayaliId = db.TblGuide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Kayalı").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulKayaliLocationCount.Text = db.TblLocation.Where(x => x.GuideId == aysegulKayaliId).Count().ToString();
        }
    }
}
