using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DofMetiers
{
    public class BesoinMetier
    {
        public int NiveauDebut { get; set; }

        public int NiveauFin { get; set; }

        public Dictionary<Craft, int> QuantiteeCraft { get; set; }

        public BesoinMetier(int niveauDebut, int niveauFin, Craft craft, int quantitee)
        {
            NiveauDebut = niveauDebut;
            NiveauFin = niveauFin;
            QuantiteeCraft = new Dictionary<Craft, int>();
            QuantiteeCraft[craft] = quantitee;
        }
    }
}
