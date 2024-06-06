using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Statisztikak.xaml
    /// </summary>
    public partial class Statisztikak : Window
    {
        public Statisztikak()
        {
            InitializeComponent();
            List<Ugyfel> visszaterok = new List<Ugyfel>();
            foreach (var item in MainWindow.ugyfelek)
            {
                if (item.Visszajaro)
                {
                    visszaterok.Add(item);
                }
            }
            dgrVisszaterok.ItemsSource = visszaterok;

            Szoba legtobbet = MainWindow.szobak[0];
            int bevetel = 0;
            foreach (var item in MainWindow.szobak)
            {
                if (item.Kiadasok >legtobbet.Kiadasok)
                {
                    legtobbet = item;
                }
                if (item.Foglalt)
                {
                    TimeSpan napok = new DateTime(int.Parse(item.Meddig.Split('.')[0]), int.Parse(item.Meddig.Split('.')[1]), int.Parse(item.Meddig.Split('.')[2])) -
                                    new DateTime(int.Parse(item.Mettol.Split('.')[0]), int.Parse(item.Mettol.Split('.')[1]), int.Parse(item.Mettol.Split('.')[2]));
                    bevetel += item.Ferohelyek * item.Ar * napok.Days;
                }
            }
            lblLegtobbet.Content = $"Legtöbbet kiadott szoba száma: {legtobbet.Szobaszam}";
            lblOsszes.Content = $"Összes: {bevetel}Ft";
        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSzamitas_Click(object sender, RoutedEventArgs e)
        {
            int bevetel = 0;
            foreach (var item in MainWindow.szobak)
            {
                if (item.Foglalt && 
                    new DateTime(int.Parse(item.Mettol.Split('.')[0]), int.Parse(item.Mettol.Split('.')[1]), int.Parse(item.Mettol.Split('.')[2])) >=
                    new DateTime(int.Parse(txbEttol.Text.Split('.')[0]), int.Parse(txbEttol.Text.Split('.')[1]), int.Parse(txbEttol.Text.Split('.')[2])) &&
                    new DateTime(int.Parse(item.Mettol.Split('.')[0]), int.Parse(item.Mettol.Split('.')[1]), int.Parse(item.Mettol.Split('.')[2])) <=
                    new DateTime(int.Parse(txbEddig.Text.Split('.')[0]), int.Parse(txbEddig.Text.Split('.')[1]), int.Parse(txbEddig.Text.Split('.')[2]))
                    )
                {
                    TimeSpan napok = new DateTime(int.Parse(item.Meddig.Split('.')[0]), int.Parse(item.Meddig.Split('.')[1]), int.Parse(item.Meddig.Split('.')[2])) -
                                    new DateTime(int.Parse(item.Mettol.Split('.')[0]), int.Parse(item.Mettol.Split('.')[1]), int.Parse(item.Mettol.Split('.')[2]));
                    bevetel += item.Ferohelyek * item.Ar * napok.Days;
                }
                lblIdoszakos.Content = $"Időszakon belüli: {bevetel}Ft";            
            }
        }
    }
}
