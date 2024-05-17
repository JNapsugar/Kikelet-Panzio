using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace Kikelet_Panzió
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
    {
        Szobakezeles szobakezelesAblak;
        public static List<Szoba> szobak = new List<Szoba>();
        public MainWindow()
        {
            InitializeComponent();
            
            Random random = new Random();
            for (int i = 1; i <=100; i++)
            {
                DateTime mettol = DatumCsinalo(random);
                DateTime meddig = DatumCsinalo(random);

                while (meddig < mettol)
                {
                    meddig = DatumCsinalo(random);
                }
                szobak.Add(new Szoba(Convert.ToString(i), random.Next(1, 7), random.Next(6000, 12001), Convert.ToBoolean(random.Next(0, 2)), $"{mettol.Year}.{mettol.Month}.{mettol.Day}", $"{meddig.Year}.{meddig.Month}.{meddig.Day}"));
            }
        }

        private static DateTime  DatumCsinalo(Random random)
        {
            int ev = random.Next(2023, 2026);
            int honap = random.Next(1, 13);
            int nap = random.Next(1, 31);
            DateTime datum;

            while (DateTime.TryParse($"{ev}.{honap}.{nap}", out datum) == false)
            {
                ev = random.Next(2023, 2026);
                honap = random.Next(1, 13);
                nap = random.Next(1, 31);
            }
            DateTime.TryParse($"{ev}.{honap}.{nap}", out datum);


            return datum;
        }

        private void btnSzobakezeles_Click(object sender, RoutedEventArgs e)
        {
            szobakezelesAblak = new Szobakezeles();
            szobakezelesAblak.ShowDialog();
        }
    }
}
