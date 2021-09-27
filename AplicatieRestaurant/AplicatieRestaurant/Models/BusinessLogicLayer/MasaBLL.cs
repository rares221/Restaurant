using AplicatieRestaurant.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.BusinessLogicLayer
{
    class MasaBLL
    {
        MasaDAL masaDAL = new MasaDAL();

        internal List<Masa> ToateMesele()
        {
            return masaDAL.ToateMesele();
        }
        internal void AdaugaMasa(Masa masa)
        {
            masaDAL.AdaugareMasa(masa);
        }

        internal void ModificaMasa(Masa masa)
        {
            masaDAL.ModificareMasa(masa);
        }

        internal void StergeMasa(Masa masa)
        {
            masaDAL.StergeMasa(masa);
        }
    }
}
