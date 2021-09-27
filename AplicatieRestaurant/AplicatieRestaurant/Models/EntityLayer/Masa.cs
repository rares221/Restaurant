using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models
{
    public class Masa
    {
        public int ID { get; set; }

        public int Numar { get; set; }

        public int NrLocuriLibere { get; set; }

        public int NrLocuriOcupate { get; set; }

        public string NumeOspatar { get; set; }
    }
}
