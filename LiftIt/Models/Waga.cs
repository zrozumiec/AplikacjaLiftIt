using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models
{
    public class Waga
    {
        public int WagaId { get; set; }
        public double WagaCiala { get; set; }
        public double Tluszcz { get; set; }
        public double Miesnie { get; set; }
        public double Woda { get; set; }
        public double Kosci { get; set; }
        public double BMI { get; set; }
        public string StringDataPomiaru { get; set; }
        public DateTime DataPomiaru { get; set; }

        public string UserId { get; set; }
        
        public virtual ApplicationUser User { get; set; }
    }
}
