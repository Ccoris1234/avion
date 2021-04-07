using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class mesaj
    {
        public int mesajId { get; set; }

        public string nume { get; set; }

        public string prenume { get; set; }

        public string text { get; set; }

        public string email { get; set; }

        public int avionId { get; set; }

        public avion avion { get; set; }
    }
}
