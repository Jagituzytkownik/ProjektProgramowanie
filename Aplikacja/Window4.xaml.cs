using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        DataContext db = new DataContext(@"Server =(LocalDb)\.;Initial Catalog = Biblioteka;User ID=MAN;Password=qwertyuiop");
        Klient x = null;
        /// <summary>
        /// Konstruktor tworzy okno i określa wstępne parametry 
        /// </summary>
        public Window4()
        {
            InitializeComponent();
            var m = from z in db.GetTable<Klient>()
                    select $"{z.id_Klient} {z.Imie} {z.Nazwisko}";
            foreach (var t in m)
            {
                cbCzytelnika.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t });

            }
        }

        private void cbCzytelnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void btPokaż_Click(object sender, RoutedEventArgs e)
        {

            foreach (Klient a in db.GetTable<Klient>())
            {
                var s = cbCzytelnika.Text;
                var q = a.ToString().Split(' ')[0];
                var p = cbCzytelnika.Text.Split(' ')[0];
                if (a.id_Klient.ToString().Split(' ')[0] == cbCzytelnika.Text.Split(' ')[0])
                {
                    x = a;
                    break;
                }
            }
            cbImie.Text = x.Imie;
            cbNazwisko.Text = x.Nazwisko;
            cbZamieszkanie.Text = x.Zamieszkanie;
            cbTelefon.Text = x.NrTelefonu;
        }


        private void bZmień_Click(object sender, RoutedEventArgs e)
        {
            if (x != null)
            {
                x.Imie = cbImie.Text;
                x.Nazwisko = cbNazwisko.Text;
                x.Zamieszkanie = cbZamieszkanie.Text;
                x.NrTelefonu = cbTelefon.Text;
                db.SubmitChanges();

            }
            else
            {
                Klient f = new Klient()
                {
                    id_Klient = db.GetTable<Klient>().Count() + 1,
                    Imie = cbImie.Text,
                    Nazwisko = cbNazwisko.Text,
                    Zamieszkanie = cbZamieszkanie.Text,
                    NrTelefonu = cbTelefon.Text
                };
                db.GetTable<Klient>().InsertOnSubmit(f);
                db.SubmitChanges();
            }
        }
    }
}
