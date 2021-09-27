using AplicatieRestaurant.Models;
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
    /// Interaction logic for Mese.xaml
    /// </summary>
    public partial class Mese : Window
    {
        public Mese()
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
            AdaugaMasa adaugaMasa = new AdaugaMasa();
            adaugaMasa.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            ModificaMasa modificaMasa = new ModificaMasa(ModificaMasa.MasaCurenta);
            modificaMasa.Show();
            this.Close();
        }

        private void OspatarBtn_Click(object sender, RoutedEventArgs e)
        {
            OspatarulUneiMese ospatarulUneiMese = new OspatarulUneiMese();
            ospatarulUneiMese.Show();
            this.Close();
        }
    }
}
