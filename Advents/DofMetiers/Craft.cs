using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DofMetiers
{
    public class Craft
    {
        public string Name { get; set; }

        public Dictionary<Ressource, int> CraftItems { get; set; }

        public Craft(string name, List<KeyValuePair<Ressource, int>> listRessourceQuantitee) 
        {
            this.Name = name;
            CraftItems = new Dictionary<Ressource, int>();
            foreach (var keyValuePair in listRessourceQuantitee)
            {
                CraftItems[keyValuePair.Key] = keyValuePair.Value;
            }
        }

    }
}
