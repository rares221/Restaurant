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
    /// Interaction logic for AdaugaOspatar.xaml
    /// </summary>
    public partial class AdaugaOspatar : Window
    {
        public AdaugaOspatar()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Ospatari ospatari = new Ospatari();
            ospatari.Show();
            this.Close();
        }
    }
}
