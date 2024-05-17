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
    /// Interaction logic for Szobakezeles.xaml
    /// </summary>
    public partial class Szobakezeles : Window
    {
        Szoba mutatottszoba;
        public Szobakezeles()
        {
            InitializeComponent();
            dgrSzobak.ItemsSource = MainWindow.szobak;
            dgrSzobak.SelectedIndex = 0;
            int[] ferohelyek = { 1, 2, 3, 4, 5, 6 };
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

            if (mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '1' ||
                mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '2' ||
                mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '4' ||
                mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '7' ||
                mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '9' ||
                mutatottszoba.Szobaszam.Length > 1 &&
                $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}"  == "10" ||
                mutatottszoba.Szobaszam.Length > 1 &&
                $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "40" ||
                mutatottszoba.Szobaszam.Length > 1 &&
                $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "50" ||
                mutatottszoba.Szobaszam.Length > 1 &&
                $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "70" ||
                mutatottszoba.Szobaszam.Length > 1 &&
                $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "90"
                )
            {
                lblSzobaszam.Content = mutatottszoba.Szobaszam + "-es szoba";
            }
            else if (mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '3' ||
                     mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '8' ||
                     mutatottszoba.Szobaszam.Length > 1 &&
                     $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "20" ||
                     mutatottszoba.Szobaszam.Length > 1 &&
                     $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "30" ||
                     mutatottszoba.Szobaszam.Length > 1 &&
                     $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "60" ||
                     mutatottszoba.Szobaszam.Length > 1 &&
                     $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "80" ||
                     mutatottszoba.Szobaszam.Length > 2 &&
                     $"{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 2]}{mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1]}" == "00")
            {
                lblSzobaszam.Content = mutatottszoba.Szobaszam + "-as szoba";
            }
            else if (mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '5')
            {
                lblSzobaszam.Content = mutatottszoba.Szobaszam + "-ös szoba";
            }
            else if (mutatottszoba.Szobaszam[mutatottszoba.Szobaszam.Length - 1] == '6')
            {
                lblSzobaszam.Content = mutatottszoba.Szobaszam + "-os szoba";
            }



        }

    }
}
