using System;
using System.Collections.Generic;
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

namespace Kikelet_Panzió
{
    /// <summary>
    /// Interaction logic for Szobafoglalas.xaml
    /// </summary>
    public partial class Szobafoglalas : Window
    {
        Szoba valasztottszoba;
        static string[] ferohelyek = { "1", "2", "3", "4", "5", "6" };
        public Szobafoglalas()
        {
            InitializeComponent();
            
            cmbFerohelyek.ItemsSource = ferohelyek;
        }

        private void dgrSzobak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgrSzobak.SelectedIndex > -1)
            {
                valasztottszoba = MainWindow.szobak[dgrSzobak.SelectedIndex];
                TimeSpan napok = new DateTime(int.Parse(txbEddig.Text.Split('.')[0]), int.Parse(txbEddig.Text.Split('.')[1]), int.Parse(txbEddig.Text.Split('.')[2])) -
                                    new DateTime(int.Parse(txbEttol.Text.Split('.')[0]), int.Parse(txbEttol.Text.Split('.')[1]), int.Parse(txbEttol.Text.Split('.')[2]));

            lblFizetendo.Content = MainWindow.belepettUgyfel.VIP? 
                    Math.Round((int.Parse(cmbFerohelyek.SelectedValue as string) * valasztottszoba.Ar) * napok.Days * 0.97) + "Ft":
                    (int.Parse(cmbFerohelyek.SelectedValue as string) * valasztottszoba.Ar) * napok.Days  + "Ft";

            }


        }

        private void Kereses_Click(object sender, RoutedEventArgs e)
        {
            if (cmbFerohelyek.SelectedIndex != -1 && DateTime.TryParse(txbEttol.Text, out DateTime ettol) && DateTime.TryParse(txbEddig.Text, out DateTime eddig) &&
                (new DateTime(int.Parse(txbEddig.Text.Split('.')[0]), int.Parse(txbEddig.Text.Split('.')[1]), int.Parse(txbEddig.Text.Split('.')[2])) -
                new DateTime(int.Parse(txbEttol.Text.Split('.')[0]), int.Parse(txbEttol.Text.Split('.')[1]), int.Parse(txbEttol.Text.Split('.')[2]))).Days > 0)
            {
                List<Szoba> szurt = new List<Szoba>();
                foreach (var item in MainWindow.szobak)
                {
                    if (item.Ferohelyek >= int.Parse(cmbFerohelyek.SelectedValue as string) && item.Foglalt == false)
                    {
                        szurt.Add(item);
                    }
                }
                dgrSzobak.ItemsSource = szurt;
            }
            else
            {
                MessageBox.Show("Nem megfelelő adatok");
            }

        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Foglalas_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan napok = new DateTime(int.Parse(txbEddig.Text.Split('.')[0]), int.Parse(txbEddig.Text.Split('.')[1]), int.Parse(txbEddig.Text.Split('.')[2])) -
                             new DateTime(int.Parse(txbEttol.Text.Split('.')[0]), int.Parse(txbEttol.Text.Split('.')[1]), int.Parse(txbEttol.Text.Split('.')[2]));
            valasztottszoba = MainWindow.szobak[dgrSzobak.SelectedIndex];
            MainWindow.szobak[dgrSzobak.SelectedIndex].Foglalt = true;
            MainWindow.szobak[dgrSzobak.SelectedIndex].Mettol = txbEttol.Text;
            MainWindow.szobak[dgrSzobak.SelectedIndex].Meddig = txbEddig.Text;
            MainWindow.szobak[dgrSzobak.SelectedIndex].FoglaltFo = int.Parse(cmbFerohelyek.SelectedValue as string);
            MainWindow.szobak[dgrSzobak.SelectedIndex].Kiadasok ++;
            MainWindow.belepettUgyfel.Visszajaro = true;
            MainWindow.belepettUgyfel.Fizetett = MainWindow.belepettUgyfel.VIP ?
                    int.Parse(Math.Round((int.Parse(cmbFerohelyek.SelectedValue as string) * valasztottszoba.Ar) * napok.Days * 0.97) + "") :
                    int.Parse((int.Parse(cmbFerohelyek.SelectedValue as string) * valasztottszoba.Ar) * napok.Days+"");
            MessageBox.Show("Sikeres foglalás");
            Close();
        }

        private void txbEttol_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgrSzobak.SelectedIndex = -1;
            dgrSzobak.ItemsSource = null;
            lblFizetendo.Content = "";
        }

        private void txbEddig_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgrSzobak.SelectedIndex = -1;
            dgrSzobak.ItemsSource = null;
            lblFizetendo.Content = "";
        }

        private void cmbFerohelyek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dgrSzobak.SelectedIndex = -1;
            dgrSzobak.ItemsSource = null;
            lblFizetendo.Content = "";
        }
    }
}
