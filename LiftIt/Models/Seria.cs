using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models
{
    public class Seria
    {
        public int SeriaId { get; set; }
        public int LiczbaPowtorzen { get; set; }
        public double Ciezar { get; set; }

        public int CwiczeniaId { get; set; }

        public virtual Cwiczenia Cwiczenia { get; set; }
    }
}
