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

namespace AplicatieRestaurant.Views
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ProduseBtn_Click(object sender, RoutedEventArgs e)
        {
            Produse produse = new Produse();
            produse.Show();
            this.Close();
        }

        private void OspatariBtn_Click(object sender, RoutedEventArgs e)
        {
            Ospatari ospatari = new Ospatari();
            ospatari.Show();
            this.Close();
        }

        private void MeseBtn_Click(object sender, RoutedEventArgs e)
        {
            Mese mese = new Mese();
            mese.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
    }
}
