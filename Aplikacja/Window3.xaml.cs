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
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {  
        DataContext db = new DataContext(@"Server =(LocalDb)\.;Initial Catalog = Biblioteka;User ID=MAN;Password=qwertyuiop");
        /// <summary>
        /// Konstruktor tworzy okno i określa wstępne parametry 
        /// </summary>
        public Window3()
        {
            InitializeComponent();

            foreach (Klient t in db.GetTable<Klient>())
            {
                cbCzytelnik.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t, Name = $"czytelnik00{t.id_Klient}" });

            }
            var p = from t in db.GetTable<Książki>()
                    join x in db.GetTable<Autorzy>() on t.id_Autor equals x.id_Autor
                    join y in db.GetTable<Tytuły>() on t.id_Tytuł equals y.id_Tytuł
                    join v in db.GetTable<Kategoria>() on t.id_Kategorie equals v.id_Kategorie
                    select $"{t.id_Książka} {x.Autor} {y.Tytuł} ";

            foreach (var s in p)
            {
                cbKsiążka.Items.Add(new ComboBoxItem() { IsSelected = false, Content = s, Name = "książka00" });
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Klient x = null;
            Książki y = null;
            foreach (Klient t in db.GetTable<Klient>())
            {
                if (cbCzytelnik.SelectionBoxItem.ToString() == t.ToString())
                {
                    x = t;
                    break;
                }
            }
            foreach (Książki t in db.GetTable<Książki>())
            {
                string a = cbKsiążka.SelectedItem.ToString().Split(' ')[1];
                string b = t.ToString().Split(' ')[0];
                if (cbKsiążka.SelectedItem.ToString().Split(' ')[1] == t.ToString().Split(' ')[0])
                {

                    y = t;
                    break;
                }
            }
            if (x != null && y != null)
            {
                Wypożyczenia wypożyczenia = new Wypożyczenia()
                {
                    id_Wypożyczenia = db.GetTable<Wypożyczenia>().Count() + 1,
                    id_Klient = x.id_Klient,
                    id_Książka = y.id_Książka,
                    dataWypożyczenia = DateTime.Now.Date,
                    dataOddania = DateTime.Now.Date.AddDays(30)
                };
                db.GetTable<Wypożyczenia>().InsertOnSubmit(wypożyczenia);
                db.SubmitChanges();
            }
        }

    }
}

