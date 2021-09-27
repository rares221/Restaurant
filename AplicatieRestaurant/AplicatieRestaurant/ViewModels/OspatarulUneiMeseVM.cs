using AplicatieRestaurant.Models;
using AplicatieRestaurant.Models.BusinessLogicLayer;
using AplicatieRestaurant.Models.EntityLayer;
using AplicatieRestaurant.ViewModels.Commands;
using AplicatieRestaurant.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AplicatieRestaurant.ViewModels
{
    class OspatarulUneiMeseVM : BasePropertyChanged
    {
        UtilizatorBLL utilizatorBLL;
        MasaBLL masaBLL;
        List<Utilizator> ospatari;
        List<Masa> mese;
        bool exista = false;
        public OspatarulUneiMeseVM()
        {
            utilizatorBLL = new UtilizatorBLL();
            masaBLL = new MasaBLL();

            ospatari = utilizatorBLL.TotiOspatarii();
            mese = masaBLL.ToateMesele();

            foreach (var ospatar in ospatari)
            {
                if (ModificaMasa.MasaCurenta.NumeOspatar == ospatar.Nume)
                {
                    Nume = ospatar.Nume;
                    Prenume = ospatar.Prenume;
                    exista = true;
                }
            }

            if(exista)
            {
                Sterge = true;
                Adauga = false;
            }
            else
            {
                Sterge = false;
                Adauga = true;
            }

            Numar = ModificaMasa.MasaCurenta.Numar;
        }

        string nume;
        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
                NotifyPropertyChanged("Nume");
            }
        }

        string prenume;
        public string Prenume
        {
            get
            {
                return prenume;
            }
            set
            {
                prenume = value;
                NotifyPropertyChanged("Prenume");
            }
        }

        int numar;
        public int Numar
        {
            get
            {
                return numar;
            }
            set
            {
                numar = value;
                NotifyPropertyChanged("Numar");
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

        bool adauga;
        public bool Adauga
        {
            get
            {
                return adauga;
            }
            set
            {
                adauga = value;
                NotifyPropertyChanged("Adauga");
            }
        }

        public void MutaOspatar(object o)
        {
            ModificaMasa.MasaCurenta.NumeOspatar = null;

            masaBLL.ModificaMasa(ModificaMasa.MasaCurenta);

            Nume = String.Empty;
            Prenume = String.Empty;
            
            MessageBox.Show("Ospatarul nu se mai ocupa de aceasta masa!");
        }


        private ICommand muta;
        public ICommand Muta
        {
            get
            {
                if (muta == null)
                {
                    muta = new RelayCommand(MutaOspatar);
                }
                return muta;
            }
        }
    }
}
