using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class cariera
    {
        public int carieraId { get; set; }

        public string nume { get; set; }

        public string prenume { get; set; }

        public string calitati { get; set; }

        public int avionId { get; set; }

        public avion avion { get; set; }

        public ICollection<job> joburi { get; set; }
    }
}
