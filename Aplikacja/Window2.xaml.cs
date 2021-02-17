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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        DataContext db = new DataContext(@"Server =(LocalDb)\.;Initial Catalog = Biblioteka;User ID=MAN;Password=qwertyuiop");
        /// <summary>
        /// Konstruktor tworzy okno i określa wstępne parametry 
        /// </summary>
        public Window2()
        {
            InitializeComponent();
            var s = from z in db.GetTable<Wypożyczenia>()
                    join x in db.GetTable<Klient>() on z.id_Klient equals x.id_Klient
                    join y in db.GetTable<Książki>() on z.id_Książka equals y.id_Książka
                    join v in db.GetTable<Tytuły>() on y.id_Tytuł equals v.id_Tytuł
                    select $"{z.id_Wypożyczenia} {x.Imie} {x.Nazwisko} {v.Tytuł} {z.dataWypożyczenia} {z.dataOddania}";
            foreach (var t in s)
            {
                cbWypożyczenia.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t });
            }
            foreach (Klient t in db.GetTable<Klient>())
            {
                cbCzytelnik.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t });

            }
            var k = from z in db.GetTable<Książki>()
                    join x in db.GetTable<Tytuły>() on z.id_Tytuł equals x.id_Tytuł
                    join y in db.GetTable<Autorzy>() on z.id_Autor equals y.id_Autor
                    join v in db.GetTable<Kategoria>() on z.id_Kategorie equals v.id_Kategorie
                    select $"{x.Tytuł} {y.Autor}";
            foreach (var t in k)
            {
                cbKsiążka.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t });
            }

        }

        private void bUsuń_Click(object sender, RoutedEventArgs e)
        {
            Usuń();
        }
        private void Usuń()
        {
            foreach (Wypożyczenia a in db.GetTable<Wypożyczenia>())
            {
                if (a.id_Wypożyczenia.ToString().Split(' ')[0] == cbWypożyczenia.Text.Split(' ')[0])
                {
                    db.GetTable<Wypożyczenia>().DeleteOnSubmit(a);
                    db.SubmitChanges();
                    break;
                }
            }
            foreach (Książki a in db.GetTable<Książki>())
            {
                if (a.id_Książka.ToString().Split(' ')[0] == cbKsiążka.Text.Split(' ')[0])
                {
                    db.GetTable<Książki>().DeleteOnSubmit(a);
                    db.SubmitChanges();
                    break;
                }
            }
            foreach (Klient a in db.GetTable<Klient>())
            {
                if (a.id_Klient.ToString().Split(' ')[0] == cbCzytelnik.Text.Split(' ')[0])
                {
                    db.GetTable<Klient>().DeleteOnSubmit(a);
                    db.SubmitChanges();
                    break;
                }
            }
        }
    }
}