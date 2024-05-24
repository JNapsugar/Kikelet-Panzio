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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kikelet_Panzió
{
    /// <summary>
    /// Interaction logic for Szobakezeles.xaml
    /// </summary>
    public partial class Szobakezeles : Window
    {
        Szoba mutatottszoba;
        int[] ferohelyek = { 1, 2, 3, 4, 5, 6 };
        bool ujszoba = false;
        public Szobakezeles()
        {
            InitializeComponent();
            dgrSzobak.ItemsSource = MainWindow.szobak;
            dgrSzobak.SelectedIndex = 0;
            cmbFerohelyek.ItemsSource = ferohelyek;
            DataContext = MainWindow.szobak[0];
        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void dgrSzobak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            mutatottszoba = MainWindow.szobak[dgrSzobak.SelectedIndex];
            DataContext = mutatottszoba;

            if (mutatottszoba.Foglalt)
            {
                txbEttol.IsEnabled = true;
                txbEddig.IsEnabled = true;
            }

            RagEldonto(mutatottszoba);

        }

        

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            Ellenorzes();

        }


        private void btnSzobaFelvitel_Click(object sender, RoutedEventArgs e)
        {
            cmbFerohelyek.SelectedIndex = 0;
            txbAr.Text = "";
            cbxFoglalt.IsChecked = false;
            txbEttol.Text = "";
            txbEddig.Text = "";
            Szoba ujSzoba = new Szoba(Convert.ToString(MainWindow.szobak.Count + 1), 0, 0, false, "", "");
            mutatottszoba = ujSzoba;
            RagEldonto(mutatottszoba);
            ujszoba = true;
        }
        
        private void Ellenorzes()
        {
            bool megfelelo = true;
            mutatottszoba.Ferohelyek = ferohelyek[cmbFerohelyek.SelectedIndex];
            if (int.TryParse(txbAr.Text, out int ar) && int.Parse(txbAr.Text) >= 6000 && int.Parse(txbAr.Text) <= 12000)
            {
                mutatottszoba.Ar = int.Parse(txbAr.Text);
            }
            else
            {
                MessageBox.Show("Az ár nem megfelelő");
                megfelelo = false;
            }

            mutatottszoba.Foglalt = Convert.ToBoolean(cbxFoglalt.IsChecked);
            if (mutatottszoba.Foglalt)
            {
                if (DateTime.TryParse($"{txbEttol.Text.Split('.')[0]}.{txbEttol.Text.Split('.')[1]}.{txbEttol.Text.Split('.')[2]}", out DateTime ettol) &&
                    DateTime.TryParse($"{txbEddig.Text.Split('.')[0]}.{txbEddig.Text.Split('.')[1]}.{txbEddig.Text.Split('.')[2]}", out DateTime eddig) &&
                    ettol < eddig)
                {
                    mutatottszoba.Mettol = txbEttol.Text;
                    mutatottszoba.Meddig = txbEddig.Text;
                }
                else
                {
                    MessageBox.Show("Nem megfelelő dátum");
                    megfelelo = false;
                }
            }


            if (megfelelo && !ujszoba)
            {
                MessageBox.Show("Sikeres módosítás");
            }
            else if (megfelelo && ujszoba)
            {
                MessageBox.Show("Sikeres felvitel");
                MainWindow.szobak.Add(mutatottszoba);
            }
            dgrSzobak.Items.Refresh();
            ujszoba = false;
        }

        private void RagEldonto(Szoba szoba)
        {
            if (szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '1' ||
                szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '2' ||
                szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '4' ||
                szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '7' ||
                szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '9' ||
                szoba.Szobaszam.Length > 1 &&
                $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "10" ||
                szoba.Szobaszam.Length > 1 &&
                $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "40" ||
                szoba.Szobaszam.Length > 1 &&
                $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "50" ||
                szoba.Szobaszam.Length > 1 &&
                $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "70" ||
                szoba.Szobaszam.Length > 1 &&
                $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "90"
                )
            {
                lblSzobaszam.Content = szoba.Szobaszam + "-es szoba";
            }
            else if (szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '3' ||
                     szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '8' ||
                     szoba.Szobaszam.Length > 1 &&
                     $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "20" ||
                     szoba.Szobaszam.Length > 1 &&
                     $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "30" ||
                     szoba.Szobaszam.Length > 1 &&
                     $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "60" ||
                     szoba.Szobaszam.Length > 1 &&
                     $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "80" ||
                     szoba.Szobaszam.Length > 2 &&
                     $"{szoba.Szobaszam[szoba.Szobaszam.Length - 2]}{szoba.Szobaszam[szoba.Szobaszam.Length - 1]}" == "00")
            {
                lblSzobaszam.Content = szoba.Szobaszam + "-as szoba";
            }
            else if (szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '5')
            {
                lblSzobaszam.Content = szoba.Szobaszam + "-ös szoba";
            }
            else if (szoba.Szobaszam[szoba.Szobaszam.Length - 1] == '6')
            {
                lblSzobaszam.Content = szoba.Szobaszam + "-os szoba";
            }
        }
    }
}
