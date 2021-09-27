using AplicatieRestaurant.Models;
using AplicatieRestaurant.Models.BusinessLogicLayer;
using AplicatieRestaurant.Models.EntityLayer;
using AplicatieRestaurant.ViewModels.Commands;
using AplicatieRestaurant.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AplicatieRestaurant.ViewModels
{
    class OspatariVM : BasePropertyChanged
    {
        UtilizatorBLL utilizatorBLL;

        public OspatariVM()
        {
            utilizatorBLL = new UtilizatorBLL();
            Utilizatori = new ObservableCollection<Utilizator>(utilizatorBLL.TotiOspatarii());
        }

        ObservableCollection<Utilizator> utilizatori;
        public ObservableCollection<Utilizator> Utilizatori
        {
            get
            {
                return utilizatori;
            }
            set
            {
                utilizatori = value;
                NotifyPropertyChanged("Utilizatori");
            }
        }

        bool sterge;
        public bool Sterge
        {
            get
            {
                return sterge;
            }
            set
            {
                sterge = value;
                NotifyPropertyChanged("Sterge");
            }
        }

        private Utilizator utilizatorSelectat;
        public Utilizator UtilizatorSelectat
        {
            get
            {
                return utilizatorSelectat;
            }
            set
            {
                utilizatorSelectat = value;
                ModificaOspatar.OspatarCurent = value;
                if (utilizatorSelectat != null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("UtilizatorSelectat");
            }
        }

        public void StergeUtilizator(object o)
        {
            utilizatorBLL.StergeUtilizator(UtilizatorSelectat);

            Utilizatori = new ObservableCollection<Utilizator>(utilizatorBLL.TotiOspatarii());

            MessageBox.Show("Ospatar sters!");
        }


        private ICommand stergereUtilizator;
        public ICommand StergereUtilizator
        {
            get
            {
                if (stergereUtilizator == null)
                {
                    stergereUtilizator = new RelayCommand(StergeUtilizator);
                }
                return stergereUtilizator;
            }
        }
    }
}
