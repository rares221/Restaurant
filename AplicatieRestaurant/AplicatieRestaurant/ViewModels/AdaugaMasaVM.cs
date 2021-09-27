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
    class AdaugaMasaVM : BasePropertyChanged
    {
        MasaBLL masaBLL;
        public AdaugaMasaVM()
        {
            masaBLL = new MasaBLL();
            if (ModificaMasa.MasaCurenta != null)
            {
                ID = ModificaMasa.MasaCurenta.ID;
                Numar = ModificaMasa.MasaCurenta.Numar;
                NumarLocuri = ModificaMasa.MasaCurenta.NrLocuriLibere + ModificaMasa.MasaCurenta.NrLocuriOcupate;
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

        int numarLocuri;
        public int NumarLocuri
        {
            get
            {
                return numarLocuri;
            }
            set
            {
                numarLocuri = value;
                NotifyPropertyChanged("NumarLocuri");
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

        public void AdaugaMasa(object o)
        {
            bool exista = false;
            List<Masa> mese = masaBLL.ToateMesele();
            foreach (Masa m in mese)
            {
                if (m.Numar == Numar)
                {
                    MessageBox.Show("Exista deja o masa cu acest numar!");
                    exista = true;
                }
            }
            if(!exista)
            {
                Masa masa = new Masa()
                {
                    Numar = Numar,
                    NrLocuriLibere = NumarLocuri,
                    NrLocuriOcupate = 0,
                };

                masaBLL.AdaugaMasa(masa);

                MessageBox.Show("Masa a fost adaugat cu succes!");
                Numar = 0;
                NumarLocuri = 0;
            }
            
        }

        private ICommand adauga;
        public ICommand Adauga
        {
            get
            {
                if (adauga == null)
                {
                    adauga = new RelayCommand(AdaugaMasa);
                }
                return adauga;
            }
        }

        public void ModificareMasa(object o)
        {
            bool exista = false;
            List<Masa> mese = masaBLL.ToateMesele();
            foreach (Masa m in mese)
            {
                if (m.Numar == Numar && Numar != ModificaMasa.MasaCurenta.Numar)
                {
                    MessageBox.Show("Exista deja o masa cu acest numar!");
                    exista = true;
                }
            }
            if (!exista)
            {
                Masa masa = new Masa()
                {
                    ID = ID,
                    Numar = Numar,
                    NrLocuriLibere = NumarLocuri,
                    NrLocuriOcupate = 0,
                };

                masaBLL.ModificaMasa(masa);

                MessageBox.Show("Datele mesei au fost modificate!");
                Numar = 0;
                NumarLocuri = 0;
            }
        }

        private ICommand modifica;
        public ICommand Modifica
        {
            get
            {
                if (modifica == null)
                {
                    modifica = new RelayCommand(ModificareMasa);
                }
                return modifica;
            }
        }
    }
}
