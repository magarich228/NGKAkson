using AksonPriceList.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace AksonPriceList.Core
{
    public class MedicamentFileProvider : IMedicamentProvider
    {
        public string PathToDataFile => Directory.GetCurrentDirectory() + "\\Medicaments.txt";

        public void Add(MedicamentModel medicament, bool append = true)
        {
            string json = JsonSerializer.Serialize<MedicamentModel>(medicament);

            using (StreamWriter medicamentStream = new StreamWriter(PathToDataFile, append))
            {
                medicamentStream.WriteLine(json);
            }
        }

        public List<MedicamentModel> GetAll()
        {
            List<MedicamentModel> allMedicaments = new List<MedicamentModel>();

            using (StreamReader medicamentsReader = new StreamReader(PathToDataFile))
            {
                while (!medicamentsReader.EndOfStream) 
                {
                    allMedicaments.Add(JsonSerializer.Deserialize<MedicamentModel>(medicamentsReader.ReadLine()));
                }
            }

            return allMedicaments;
        }
    }
}
