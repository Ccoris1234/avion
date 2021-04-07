using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class beneficii
    {
        public int beneficiiId { get; set; }

        public string bauturi { get; set; }

        public string mancare { get; set; }

        public int rezervareId { get; set; }

        public rezervare rezervare { get; set; }
    }
}
