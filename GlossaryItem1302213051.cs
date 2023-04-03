using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class GlossaryItem1302213051
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"E:\modul7_kelompok_2\jurnal7_3_1302213051.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);

            Console.WriteLine("\nIsi Gloss Entry: \n");
            foreach(var item in jsonObj.glossary.GlossDiv.GlossList.GlossEntry)
            {
                Console.WriteLine(item);
            }
        }
    }
}
