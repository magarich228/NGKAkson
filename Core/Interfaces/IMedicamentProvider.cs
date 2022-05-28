using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksonPriceList.Core.Interfaces
{
    internal interface IMedicamentProvider
    {
        string PathToDataFile { get; }

        void Add(MedicamentModel model, bool append = true);

        List<MedicamentModel> GetAll();
    }
}
