using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AdaugaMasa.xaml
    /// </summary>
    public partial class AdaugaMasa : Window
    {
        public AdaugaMasa()
        {
            InitializeComponent();
        }

        private static readonly Regex conditie = new Regex("[^0-9]+");
        private static bool Text(string text)
        {
            return !conditie.IsMatch(text);
        }
        private void NumarTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Text(e.Text);
        }

        private void LocuriTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Text(e.Text);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Mese mese = new Mese();
            mese.Show();
            this.Close();
        }
    }
}
