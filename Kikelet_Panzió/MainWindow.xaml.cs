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
                string mettol = DatumCsinalo(random);
                string meddig = DatumCsinalo(random);

                while (new DateTime(int.Parse(meddig.Split('.')[0]), int.Parse(meddig.Split('.')[1]), int.Parse(meddig.Split('.')[2])) < 
                    new DateTime(int.Parse(mettol.Split('.')[0]), int.Parse(mettol.Split('.')[1]), int.Parse(mettol.Split('.')[2])))
                {
                    meddig = DatumCsinalo(random);
                }
                szobak.Add(new Szoba(Convert.ToString(i), random.Next(1, 7), random.Next(6000, 12001), Convert.ToBoolean(random.Next(0, 2)), mettol, meddig));
            }
        }

        private static string  DatumCsinalo(Random random)
        {
            string honap = Convert.ToString(random.Next(1, 13));
            string nap = Convert.ToString(random.Next(1, 32));
            if (honap.Length <= 1)
                honap = "0" + honap;
            if (nap.Length <= 1)
                nap = "0" + nap;
            string datum = $"{random.Next(2000, 2026)}.{honap}.{nap}";
            return datum;
        }

        private void btnSzobakezeles_Click(object sender, RoutedEventArgs e)
        {
            szobakezelesAblak = new Szobakezeles();
            szobakezelesAblak.ShowDialog();
        }
    }
}
