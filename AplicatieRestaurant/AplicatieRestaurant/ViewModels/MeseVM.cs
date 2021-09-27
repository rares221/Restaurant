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
    class MeseVM : BasePropertyChanged
    {
        MasaBLL masaBLL;
        public MeseVM()
        {
            masaBLL = new MasaBLL();
            Mese = new ObservableCollection<Masa>(masaBLL.ToateMesele());
        }

        ObservableCollection<Masa> mese;
        public ObservableCollection<Masa> Mese
        {
            get
            {
                return mese;
            }
            set
            {
                mese = value;
                NotifyPropertyChanged("Mese");
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

        private Masa masaSelectata;
        public Masa MasaSelectata
        {
            get
            {
                return masaSelectata;
            }
            set
            {
                masaSelectata = value;
                ModificaMasa.MasaCurenta = value;
                if (masaSelectata != null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("MasaSelectata");
            }
        }

        public void StergeMasa(object o)
        {
            masaBLL.StergeMasa(MasaSelectata);

            Mese = new ObservableCollection<Masa>(masaBLL.ToateMesele());

            MessageBox.Show("Masa stearsa!");
        }


        private ICommand stergereMasa;
        public ICommand StergereMasa
        {
            get
            {
                if (stergereMasa == null)
                {
                    stergereMasa = new RelayCommand(StergeMasa);
                }
                return stergereMasa;
            }
        }
    }
}
