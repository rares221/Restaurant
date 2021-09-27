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
    class AdaugaOspatarLaMasaVM : BasePropertyChanged
    {
        UtilizatorBLL utilizatorBLL;
        MasaBLL masaBLL;
        public AdaugaOspatarLaMasaVM()
        {
            utilizatorBLL = new UtilizatorBLL();
            masaBLL = new MasaBLL();

            Ospatari = new ObservableCollection<Utilizator>(utilizatorBLL.TotiOspatarii());
        }

        ObservableCollection<Utilizator> ospatari;

        public ObservableCollection<Utilizator> Ospatari
        {
            get
            {
                return ospatari;
            }
            set
            {
                ospatari = value;
                NotifyPropertyChanged("Ospatari");
            }
        }

        private Utilizator ospatarSelectat;
        public Utilizator OspatarSelectat
        {
            get
            {
                return ospatarSelectat;
            }
            set
            {
                ospatarSelectat = value;

                if (ospatarSelectat != null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("OspatarSelectat");
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
        public void AdaugaOspatarLaMasa(object o)
        {
            ModificaMasa.MasaCurenta.NumeOspatar = OspatarSelectat.Nume;

            masaBLL.ModificaMasa(ModificaMasa.MasaCurenta);
            
            MessageBox.Show("Ospatarul a fost atribuit acestei mese!");
        }

        private ICommand adauga;
        public ICommand Adauga
        {
            get
            {
                if (adauga == null)
                {
                    adauga = new RelayCommand(AdaugaOspatarLaMasa);
                }
                return adauga;
            }
        }
    }
}
