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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sprOdp;
        int randOdpoved;
        public MainWindow()
        {
            InitializeComponent();
            click();
        }
        public void click()
        {
            Random rnd = new Random();
            int cislo = rnd.Next(100);
            int cislo1 = rnd.Next(100);
            int cislo2 = rnd.Next(100);
            int otazkaCislo = rnd.Next(100);
            randOdpoved = rnd.Next(1, 4);

            label1.Content = "kviz :|";
            btn1.Content = cislo;
            btn2.Content = cislo1;
            btn3.Content = cislo2;

            
            if (randOdpoved == 1)
            {
                sprOdp = cislo;
            } else if (randOdpoved == 2)
            {
                sprOdp = cislo1;
            } else
            {
                sprOdp = cislo2;
            }


            int otazka = sprOdp - otazkaCislo;
            label2.Content = "kolik je " + otazka + "+" + otazkaCislo;

            if (progress.Value >= 100)
            {
                MessageBox.Show("Vyborne!");
                Close();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //click();
            if (randOdpoved == 1)
            {
                MessageBox.Show("Spravne");
                progress.Value += 10;
                click();
            }
            else
            {
                MessageBox.Show("Spatne");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (randOdpoved == 2)
            {
                MessageBox.Show("Spravne");
                progress.Value += 10;
                click();
            }
            else
            {
                MessageBox.Show("Spatne");
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (randOdpoved == 3)
            {
                MessageBox.Show("Spravne");
                progress.Value += 10;
                click();
            }
            else
            {
                MessageBox.Show("Spatne");
            }
        }
    }
}
