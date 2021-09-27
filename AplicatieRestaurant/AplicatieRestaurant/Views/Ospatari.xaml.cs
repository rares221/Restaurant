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
    /// Interaction logic for Ospatari.xaml
    /// </summary>
    public partial class Ospatari : Window
    {
        public Ospatari()
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
            AdaugaOspatar adaugaOspatar = new AdaugaOspatar();
            adaugaOspatar.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            ModificaOspatar modificaOspatar = new ModificaOspatar();
            modificaOspatar.Show();
            this.Close();
        }
    }
}
