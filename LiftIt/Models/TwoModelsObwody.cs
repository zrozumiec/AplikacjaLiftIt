using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models
{
    public class TwoModelsObwody
    {
        public IQueryable<Obwody> SelectObwody { get; set; }
        public Obwody DaneObwody { get; set; }
    }
}
