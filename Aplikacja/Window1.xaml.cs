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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {  
        DataContext db = new DataContext(@"Server =(LocalDb)\.;Initial Catalog = Biblioteka;User ID=MAN;Password=qwertyuiop");
        /// <summary>
        /// Konstruktor tworzy okno i określa wstępne parametry 
        /// </summary>
        public Window1()
        {
            InitializeComponent();
        

      
            
            foreach (Autorzy t in db.GetTable<Autorzy>())
            {
                cbAutor.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t.Autor });
            }
            foreach (Tytuły t in db.GetTable<Tytuły>())
            {
                cbTytuł.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t.Tytuł });
            }
            foreach (Kategoria t in db.GetTable<Kategoria>())
            {
                cbGatunek.Items.Add(new ComboBoxItem() { IsSelected = false, Content = t.Kategorie});
            }

        }

        private void bZapisz_Click(object sender, RoutedEventArgs e)
        {
            Dodaj();
        }
        private void Dodaj()
        {
            Kategoria e = null;
            Autorzy c = null;
            Tytuły d = null;
            foreach (Autorzy t in db.GetTable<Autorzy>())
            {
                if (t.Autor == cbAutor.Text)
                {
                    c = t;
                    break;
                }

            }
            foreach (Tytuły t in db.GetTable<Tytuły>())
            {
                if (t.Tytuł == cbTytuł.Text)
                {
                    d = t;
                    break;
                }

            }
            foreach (Kategoria t in db.GetTable<Kategoria>())
            {
                if (t.Kategorie == cbGatunek.Text)
                {
                    e = t;
                    break;
                }

            }
            if (c == null)
            {
                c = new Autorzy()
                {
                    id_Autor = db.GetTable<Autorzy>().Count() + 1,
                    Autor = cbAutor.Text
                };
                db.GetTable<Autorzy>().InsertOnSubmit(c);
            }
            if (d == null)
            {
                d = new Tytuły()
                {
                    id_Tytuł = db.GetTable<Tytuły>().Count() + 1,
                    Tytuł = cbTytuł.Text
                };
                db.GetTable<Tytuły>().InsertOnSubmit(d);
            }
            if (e == null)
            {
                e = new Kategoria()
                {
                    id_Kategorie = db.GetTable<Kategoria>().Count() + 1,
                    Kategorie = cbGatunek.Text
                };
                db.GetTable<Kategoria>().InsertOnSubmit(e);
            }


            Książki książki = new Książki()
            {
                id_Książka = db.GetTable<Książki>().Count() + 1,
                id_Autor = c.id_Autor,
                id_Kategorie = e.id_Kategorie,
                id_Tytuł = d.id_Tytuł

            };
            db.GetTable<Książki>().InsertOnSubmit(książki);
            db.SubmitChanges();

        }
    }
}
