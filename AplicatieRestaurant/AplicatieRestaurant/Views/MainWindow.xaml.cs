using AplicatieRestaurant.Models;
using AplicatieRestaurant.Models.BusinessLogicLayer;
using AplicatieRestaurant.Views;
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

namespace AplicatieRestaurant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            bool ok = false;
            string rol="";
            UtilizatorBLL utilizatorBLL = new UtilizatorBLL();
           
            List<Utilizator> utilizatori = utilizatorBLL.TotiUtilizatorii();
            foreach (var utilizator in utilizatori)
            {
                if (utilizator.NumeUtilizator == this.UsernameTxt.Text && utilizator.Parola == this.PasswordTxt.Password)
                {
                    ok = true;
                    rol = utilizator.Rol;
                }
            }
            if (ok)
            {
                if(rol == "administrator")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                }
                else if(rol == "ospatar")
                {
                    Ospatar ospatar = new Ospatar();
                    ospatar.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Numele de utilizator sau parola incorecte!");
            }
        }
    }
}
