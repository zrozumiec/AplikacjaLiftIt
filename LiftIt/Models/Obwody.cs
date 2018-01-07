using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models
{
    public class Obwody
    {
        public int ObwodyId { get; set; }
        public double Lydka { get; set; }
        public double Udo { get; set; }
        public double Biodra { get; set; }
        public double Talia { get; set; }
        public double Klatka { get; set; }
        public double Kark { get; set; }
        public double Biceps { get; set; }
        public double Przedramie { get; set; }
        public double Nadgarstek  { get; set; }
        public string StringDataPomiaru { get; set; }
        public DateTime DataPomiaru { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
