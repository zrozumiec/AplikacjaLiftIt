using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models
{
    public class TypCwiczenie
    {
        public int TypCwiczenieId { get; set; }
        public int TypId { get; set; }
        public int CwiczenieId { get; set; }

        public virtual Typ Typ { get; set; }
        public virtual Cwiczenia Cwiczenia { get; set; }
    }
}
