using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class job
    {
        public string jobId { get; set; }

        public string numejob { get; set; }

        public string experienta { get; set; }

        public int carieraId { get; set; }

        public cariera cariera { get; set; }

    }
}
