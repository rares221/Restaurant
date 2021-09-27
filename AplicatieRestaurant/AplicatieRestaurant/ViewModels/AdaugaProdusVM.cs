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
    class AdaugaProdusVM : BasePropertyChanged
    {
        ProdusBLL produsBLL;

        public AdaugaProdusVM()
        {
            produsBLL = new ProdusBLL();
            if(ModificaProdus.ProdusCurent!=null)
            {
                ID = ModificaProdus.ProdusCurent.ID;
                Denumire = ModificaProdus.ProdusCurent.Denumire;
                Pret = ModificaProdus.ProdusCurent.Pret;
                Stoc = ModificaProdus.ProdusCurent.Stoc;
            }
        }

        string denumire;
        public string Denumire
        {
            get
            {
                return denumire;
            }
            set
            {
                denumire = value;
                NotifyPropertyChanged("Denumire");
            }
        }

        float pret;
        public float Pret
        {
            get
            {
                return pret;
            }
            set
            {
                pret = value;
                NotifyPropertyChanged("Pret");
            }
        }

        int stoc;
        public int Stoc
        {
            get
            {
                return stoc;
            }
            set
            {
                stoc = value;
                NotifyPropertyChanged("Stoc");
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

        public void AdaugaProdus(object o)
        {
            Produs produs = new Produs()
            {
                Denumire = Denumire,
                Pret = Pret,
                Stoc = Stoc
            };

            produsBLL.AdaugareProdus(produs);

            MessageBox.Show("Produsul a fost adaugat cu succes!");
            Denumire = String.Empty;
            Pret = 0;
            Stoc = 0;
        }

        private ICommand adauga;
        public ICommand Adauga
        {
            get
            {
                if (adauga == null)
                {
                    adauga = new RelayCommand(AdaugaProdus);
                }
                return adauga;
            }
        }

        public void ModificareProdus(object o)
        {
            Produs produs = new Produs()
            {
                ID = ID,
                Denumire = Denumire,
                Pret = Pret,
                Stoc = Stoc
            };

            produsBLL.ModificareProdus(produs);


            MessageBox.Show("Datele produsului au fost modificate!");
        }

        private ICommand modifica;
        public ICommand Modifica
        {
            get
            {
                if (modifica == null)
                {
                    modifica = new RelayCommand(ModificareProdus);
                }
                return modifica;
            }
        }
    }
}
