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
    /// Interaction logic for Produse.xaml
    /// </summary>
    public partial class Produse : Window
    {
        public Produse()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            ModificaProdus.ProdusCurent = null;
            AdaugaProdus adaugaProdus = new AdaugaProdus();
            adaugaProdus.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            ModificaProdus modificaProdus = new ModificaProdus(ModificaProdus.ProdusCurent);
            modificaProdus.Show();
            this.Close();
        }
    }
}
