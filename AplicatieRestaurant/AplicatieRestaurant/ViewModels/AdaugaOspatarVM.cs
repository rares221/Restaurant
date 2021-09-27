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
    class AdaugaOspatarVM : BasePropertyChanged
    {
        UtilizatorBLL utilizatorBLL;
        public AdaugaOspatarVM()
        {
            utilizatorBLL = new UtilizatorBLL();
            if (ModificaOspatar.OspatarCurent != null)
            {
                ID = ModificaOspatar.OspatarCurent.ID;
                Nume = ModificaOspatar.OspatarCurent.Nume;
                Prenume = ModificaOspatar.OspatarCurent.Prenume;
                NumeUtilizator = ModificaOspatar.OspatarCurent.NumeUtilizator;
                Parola = ModificaOspatar.OspatarCurent.Parola;
            }
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

        string numeUtilizator;
        public string NumeUtilizator
        {
            get
            {
                return numeUtilizator;
            }
            set
            {
                numeUtilizator = value;
                NotifyPropertyChanged("NumeUtilizator");
            }
        }

        string parola;
        public string Parola
        {
            get
            {
                return parola;
            }
            set
            {
                parola = value;
                NotifyPropertyChanged("Parola");
            }
        }

        int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                NotifyPropertyChanged("ID");
            }
        }

        public void AdaugaOspatar(object o)
        {
            Utilizator utilizator = new Utilizator()
            {
                Nume = Nume,
                Prenume = Prenume,
                NumeUtilizator = NumeUtilizator,
                Parola = Parola,
                Rol = "ospatar"
            };

            utilizatorBLL.AdaugaUtilizator(utilizator);

            MessageBox.Show("Ospatarul a fost adaugat cu succes!");
            Nume = String.Empty;
            Prenume = String.Empty;
            NumeUtilizator = String.Empty;
            Parola = String.Empty;
        }

        private ICommand adauga;
        public ICommand Adauga
        {
            get
            {
                if (adauga == null)
                {
                    adauga = new RelayCommand(AdaugaOspatar);
                }
                return adauga;
            }
        }

        public void ModificareOspatar(object o)
        {
            Utilizator utilizator = new Utilizator()
            {
                ID = ID,
                Nume = Nume,
                Prenume = Prenume,
                NumeUtilizator = NumeUtilizator,
                Parola = Parola,
                Rol = "ospatar"
            };

            utilizatorBLL.ModificaUtilizator(utilizator);

            MessageBox.Show("Datele ospatarului au fost modificate!");
        }

        private ICommand modifica;
        public ICommand Modifica
        {
            get
            {
                if (modifica == null)
                {
                    modifica = new RelayCommand(ModificareOspatar);
                }
                return modifica;
            }
        }
    }
}
