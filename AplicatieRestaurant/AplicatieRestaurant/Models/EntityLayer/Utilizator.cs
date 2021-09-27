using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models
{
    public class Utilizator
    {
        public int ID { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string NumeUtilizator { get; set; }
        public string Parola { get; set; }

        public string Rol { get; set; }

    }
}
