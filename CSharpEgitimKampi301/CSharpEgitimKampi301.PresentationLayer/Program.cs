using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmProduct());
        }
    }
}

/*

Migration için aşamalar;

View -> Other Windows -> Package Manager Console aç.
Package Manager Console -> Default Project (Context'in olduğu projeyi seç)
PM -> enable-migrations
Configuration.cs -> AutomaticMigrationsEnabled = true yap.
PM -> update-database

Eğer tabloyu güncellemek istersen. Değişiklikleri yaptıktan sonra;

PM -> add-migration "migration adı gir"
PM -> update-database

Refactoring Guru
 */
