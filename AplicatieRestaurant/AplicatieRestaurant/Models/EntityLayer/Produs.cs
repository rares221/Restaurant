using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models
{
    public class Produs
    {
        public int ID { get; set; }

        public string Denumire { get; set; }

        public float Pret { get; set; }

        public int Stoc { get; set; }
    }
}
