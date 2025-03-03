using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DofMetiers
{
    public enum RessourceType
    {
        Unknown,
        Paysan,
        Alchimie,
        Random
    }

    public class Ressource
    {
        public string Name { get; set; }

        public int PrixMoyen { get; set; }

        public RessourceType RessourceType { get; set; }

        public Ressource(string name, int prixMoyen, RessourceType ressourceType)
        {
            this.Name = name;
            this.PrixMoyen = prixMoyen;
            this.RessourceType = ressourceType;
        }
    }
}
