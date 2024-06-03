using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
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

        Szobakezeles SzobakezelesAblak;
        Regisztracio RegisztracioAblak;
        Bejelentkezes BejelentkezesAblak;
        Statisztikak StatisztikakAblak;
        public static Ugyfel belepettUgyfel;
        public static List<Szoba> szobak = new List<Szoba>();
        public static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        public static List<string> ugyfelAzonositok = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();


            ugyfelek.Add(new Ugyfel($"Teszt{DateTime.Today.Year}{DateTime.Today.Month}{DateTime.Today.Day}", "Teszt", "2000.01.01", "email@gmail.com", "jelszo", true, true, 55000));
            string[] nevek = {"Gavin Wilkins", "Tracey Gibson", "Justin Randall", "Piers Wilkins","Jason Dowd", "Jennifer Clarkson", "Jessica Hudson", "Diane Greene", "Peter Ross", "Dan Lambert", "Gavin Bond", "Jason Davidson", "Gordon Miller" };
            foreach (var item in nevek)
            {
                ugyfelek.Add(new Ugyfel(
                        $"{item}{random.Next(2000, 2025)}.{random.Next(1, 13)}.{random.Next(1, 31)}",
                        item,
                        $"{random.Next(1950, 2006)}.{random.Next(1, 13)}.{random.Next(1, 31)}",
                        $"{item.Replace(" ",string.Empty)}@gmail.com",
                        $"{random.Next(1000, 9999999)}",
                        Convert.ToBoolean(random.Next(0, 2)),
                        Convert.ToBoolean(random.Next(0, 2)),
                        random.Next(6000, 9999999)));
            }


            for (int i = 1; i <=100; i++)
            {
                string mettolStr = "";
                string meddigStr = "";
                bool foglalt = Convert.ToBoolean(random.Next(0, 2));
                if (foglalt)
                {
                    DateTime mettol = DatumCsinalo(random);
                    DateTime meddig = DatumCsinalo(random);
                    while (meddig < mettol)
                    {
                        meddig = DatumCsinalo(random);
                    }
                    mettolStr = $"{mettol.Year}.{mettol.Month}.{mettol.Day}";
                    meddigStr = $"{meddig.Year}.{meddig.Month}.{meddig.Day}";
                }
                int ferohelyek = random.Next(1, 7);
                szobak.Add(new Szoba(Convert.ToString(i), ferohelyek, random.Next(6000, 12001), foglalt, mettolStr, meddigStr, random.Next(0, 30), random.Next(1,ferohelyek)));
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
            SzobakezelesAblak = new Szobakezeles();
            SzobakezelesAblak.ShowDialog();
        }
        private void btnRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            RegisztracioAblak = new Regisztracio();
            RegisztracioAblak.ShowDialog();
        }
        private void btnFoglalas_Click(object sender, RoutedEventArgs e)
        {
            BejelentkezesAblak = new Bejelentkezes();
            BejelentkezesAblak.ShowDialog();
        }

        private void btnStatisztikak_Click(object sender, RoutedEventArgs e)
        {
            StatisztikakAblak = new Statisztikak();
            StatisztikakAblak.ShowDialog();
        }
    }
}
