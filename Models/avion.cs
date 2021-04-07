using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class avion
    {
        public int avionId { get; set; }

        public string locatia { get; set; }

        public ICollection<mesaj> mesaje { get; set; }

        public ICollection<rezervare> rezervari { get; set; }

        public ICollection<cariera> joburi { get; set; }
    }
}
