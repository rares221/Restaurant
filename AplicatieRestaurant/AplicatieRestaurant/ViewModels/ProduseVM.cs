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
    class ProduseVM : BasePropertyChanged
    {
        ProdusBLL produsBLL;

        public ProduseVM()
        {
            produsBLL = new ProdusBLL();
            Produse = new ObservableCollection<Produs>(produsBLL.ToateProdusele());
        }

        ObservableCollection<Produs> produse;
        public ObservableCollection<Produs> Produse
        {
            get
            {
                return produse;
            }
            set
            {
                produse = value;
                NotifyPropertyChanged("Produse");
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

        private Produs produsSelectat;
        public Produs ProdusSelectat
        {
            get
            {
                return produsSelectat;
            }
            set
            {
                produsSelectat = value;
                ModificaProdus.ProdusCurent = value;
                if (produsSelectat != null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("ProdusSelectat");
            }
        }

        public void StergeProdus(object o)
        {
            produsBLL.StergeProdus(ProdusSelectat);


            Produse = new ObservableCollection<Produs>(produsBLL.ToateProdusele());

            MessageBox.Show("Produs sters!");
        }


        private ICommand stergereProdus;
        public ICommand StergereProdus
        {
            get
            {
                if (stergereProdus == null)
                {
                    stergereProdus = new RelayCommand(StergeProdus);
                }
                return stergereProdus;
            }
        }
    }
}
