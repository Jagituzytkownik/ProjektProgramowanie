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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            DataContext db = new DataContext(@"Server =(LocalDb)\.;Initial Catalog = Biblioteka;User ID=MAN;Password=qwertyuiop");
            public MainWindow()
            {
                InitializeComponent();
           

            }

            private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (cbTable.SelectedItem == item001)
                {
                    dgTable.DataContext = db.GetTable<Autorzy>();
                    dgTable.Columns[0].Visibility = Visibility.Collapsed;
                }
                if (cbTable.SelectedItem == item002)
                {
                    dgTable.DataContext = db.GetTable<Tytuły>();
                    dgTable.Columns[0].Visibility = Visibility.Collapsed;
                }
                if (cbTable.SelectedItem == item003)
                {
                    dgTable.DataContext = from z in db.GetTable<Książki>()
                                          join x in db.GetTable<Autorzy>() on z.id_Autor equals x.id_Autor
                                          join y in db.GetTable<Tytuły>() on z.id_Tytuł equals y.id_Tytuł
                                          join v in db.GetTable<Kategoria>() on z.id_Kategorie equals v.id_Kategorie
                                          select new { Autor = x.Autor, Tytuł = y.Tytuł, Kategoria = v.Kategorie };
                }
                if (cbTable.SelectedItem == item004)
                {
                    dgTable.DataContext = db.GetTable<Klient>();
                    dgTable.Columns[0].Visibility = Visibility.Collapsed;
                }
                if (cbTable.SelectedItem == item005)
                {
                    dgTable.DataContext = db.GetTable<Wypożyczenia>();
                    dgTable.Columns[0].Visibility = Visibility.Collapsed;
                    dgTable.DataContext = from z in db.GetTable<Wypożyczenia>()
                                          join x in db.GetTable<Klient>() on z.id_Klient equals x.id_Klient
                                          join y in db.GetTable<Książki>() on z.id_Książka equals y.id_Książka
                                          join v in db.GetTable<Tytuły>() on y.id_Tytuł equals v.id_Tytuł
                                          select new { Czytelnik = $"{x.Imie} {x.Nazwisko}", Tytuł = v.Tytuł, z.dataWypożyczenia, z.dataOddania };

                }
                if (cbTable.SelectedItem == item006)
                {
                    dgTable.DataContext = db.GetTable<Kategoria>();
                    dgTable.Columns[0].Visibility = Visibility.Collapsed;
                }
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
 new Window1().Show();
         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
new Window3().Show();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
   new Window2().Show();
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
new Window4().Show();
        }
    }
    }
