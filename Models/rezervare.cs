using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class rezervare
    {
        public int rezervareId { get; set; }

        public string nume { get; set; }

        public string prenume { get; set; }

        public int clasa { get; set; }

        public int Nrbilete { get; set; }

        public int avionId { get; set; }

        public avion avion { get; set; }

        public ICollection<beneficii> beneficii { get; set; }
    }
}
