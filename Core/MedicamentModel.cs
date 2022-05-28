using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksonPriceList.Core
{
    public class MedicamentModel
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public decimal Price { get; set; }

        public List<string> Composition { get; set; }

        public Dictionary<string, List<string>> Recomendations { get; set; }
    }
}
