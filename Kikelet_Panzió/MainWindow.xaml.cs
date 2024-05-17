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
                string mettol = $"{random.Next(2000, 2026)}.{random.Next(1, 13)}.{random.Next(1, 32)}";
                szobak.Add(new Szoba(Convert.ToString(i), random.Next(1,7), random.Next(6000,12001), Convert.ToBoolean(random.Next(0,2)), "", ""));
            }
        }

        private void btnSzobakezeles_Click(object sender, RoutedEventArgs e)
        {
            szobakezelesAblak = new Szobakezeles();
            szobakezelesAblak.ShowDialog();
        }
    }
}
