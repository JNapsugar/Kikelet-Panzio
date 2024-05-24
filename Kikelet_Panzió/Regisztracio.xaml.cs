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
    /// Interaction logic for Regisztracio.xaml
    /// </summary>
    public partial class Regisztracio : Window
    {
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            bool megfelelo = true;
            string ugyfelAzonosito = $"{txbNev.Text}{DateTime.Today.Year}{DateTime.Today.Month}{DateTime.Today.Day}";
            if (MainWindow.ugyfelAzonositok.Contains(ugyfelAzonosito))
            {
                MessageBox.Show("Ön már regisztrált");
            }

            if (txbNev.Text == "")
            {
                MessageBox.Show("Nem megfelelő név");
            }

            if (txbSzületes.Text == "" ||
                txbSzületes.Text.Split('.').Length != 4 ||
                !DateTime.TryParse($"{txbSzületes.Text.Split('.')[0]}.{txbSzületes.Text.Split('.')[1]}.{txbSzületes.Text.Split('.')[2]}", out DateTime datum))
            {
                MessageBox.Show("Nem megfelelő születési dátum");
                megfelelo = false;
            }

            if (txbEmail.Text == "" ||
                !txbEmail.Text.Contains('@') ||
                txbEmail.Text.Split('@')[0].Length < 0 ||
                txbEmail.Text.Split('@')[1].Length < 0 ||
                !txbEmail.Text.Split('@')[1].Contains('.')
                )
            {
                MessageBox.Show("Nem megfelelő email cím");
                megfelelo = false;
            }


            if (megfelelo)
            {
                MainWindow.ugyfelek.Add(new Ugyfel(ugyfelAzonosito,txbNev.Text, txbSzületes.Text, txbEmail.Text.ToLower(), txbJelszo.Text, Convert.ToBoolean(cbxVIP.IsChecked)));
                MainWindow.ugyfelAzonositok.Add(ugyfelAzonosito);
                MessageBox.Show("Sikeres regisztráció");
                Close();
            }

        }
    }
}
