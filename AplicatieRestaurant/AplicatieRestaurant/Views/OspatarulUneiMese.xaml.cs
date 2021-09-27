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
    /// Interaction logic for OspatarulUneiMese.xaml
    /// </summary>
    public partial class OspatarulUneiMese : Window
    {
        public OspatarulUneiMese()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Mese mese = new Mese();
            mese.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AdaugaOspatarLaMasa adaugaOspatarLaMasa = new AdaugaOspatarLaMasa();
            adaugaOspatarLaMasa.Show();
            this.Close();
        }
    }
}
