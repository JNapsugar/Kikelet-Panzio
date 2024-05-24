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
    /// Interaction logic for Bejelentkezes.xaml
    /// </summary>
    /// 
    public partial class Bejelentkezes : Window
    {
        Szobafoglalas SzobafoglalasAblak;
        public Bejelentkezes()
        {
            InitializeComponent();
        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnBejelentkezes_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            while (i< MainWindow.ugyfelek.Count &&  MainWindow.ugyfelek[i].Nev != txbNev.Text) 
            {
                i++;
            }

            if (i < MainWindow.ugyfelek.Count && MainWindow.ugyfelek[i].Jelszo != txbJelszo.Text)
            {
                MessageBox.Show("Nem megfelelő bejelentkezési adatok");
            }
            else
            {
                MainWindow.belepettUgyfel = MainWindow.ugyfelek[i];
                SzobafoglalasAblak = new Szobafoglalas();
                SzobafoglalasAblak.ShowDialog();
            }

        }
    }
}
