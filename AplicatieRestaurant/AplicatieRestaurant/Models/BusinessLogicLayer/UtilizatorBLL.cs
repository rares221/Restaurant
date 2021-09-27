using AplicatieRestaurant.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.BusinessLogicLayer
{
    class UtilizatorBLL
    {
        UtilizatorDAL utilizatorDAL = new UtilizatorDAL();

        internal List<Utilizator> TotiUtilizatorii()
        {
            return utilizatorDAL.TotiUtilizatorii();
        }

        internal List<Utilizator> TotiOspatarii()
        {
            return utilizatorDAL.TotiOspatarii();
        }
        internal void AdaugaUtilizator(Utilizator utilizator)
        {
            utilizatorDAL.AdaugareUtilizator(utilizator);
        }

        internal void ModificaUtilizator(Utilizator utilizator)
        {
            utilizatorDAL.ModificareUtilizator(utilizator);
        }

        internal void StergeUtilizator(Utilizator utilizator)
        {
            utilizatorDAL.StergeUtilizator(utilizator);
        }
    }
}
