using AplicatieRestaurant.Models;
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
    /// Interaction logic for ModificaProdus.xaml
    /// </summary>
    public partial class ModificaProdus : Window
    {
        public static Produs ProdusCurent;
        public ModificaProdus(Produs produs)
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Produse produse = new Produse();
            produse.Show();
            this.Close();
        }

        private static readonly Regex conditieStoc = new Regex("[^0-9]+");
        private static readonly Regex conditiePret = new Regex("[^0-9.]+");
        private static bool TextStoc(string text)
        {
            return !conditieStoc.IsMatch(text);
        }

        private static bool TextPret(string text)
        {
            return !conditiePret.IsMatch(text);
        }

        private void PretTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !TextPret(e.Text);
        }

        private void StocTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !TextStoc(e.Text);
        }
    }
}
