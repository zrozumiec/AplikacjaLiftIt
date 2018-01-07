using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models
{
    public class Cwiczenia
    {
        public int CwiczeniaId { get; set; }
        public string Nazaw { get; set; }
        public int LiczbaSerii { get; set; }
        public string StringDataPomiaru { get; set; }
        public DateTime DataPomiaru { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}
