using AplicatieRestaurant.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.BusinessLogicLayer
{
    class ProdusBLL
    {
        ProdusDAL produsDAL = new ProdusDAL();

        internal List<Produs> ToateProdusele()
        {
            return produsDAL.ToateProdusele();
        }

        internal void AdaugareProdus(Produs produs)
        {
            produsDAL.AdaugareProdus(produs);
        }

        internal void ModificareProdus(Produs produs)
        {
            produsDAL.ModificareProdus(produs);
        }

        internal void StergeProdus(Produs produs)
        {
            produsDAL.StergeProdus(produs);
        }
    }
}
