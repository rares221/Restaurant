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
    /// Interaction logic for AdaugaOspatarLaMasa.xaml
    /// </summary>
    public partial class AdaugaOspatarLaMasa : Window
    {
        public AdaugaOspatarLaMasa()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            OspatarulUneiMese ospatarulUneiMese = new OspatarulUneiMese();
            ospatarulUneiMese.Show();
            this.Close();
        }
    }
}
