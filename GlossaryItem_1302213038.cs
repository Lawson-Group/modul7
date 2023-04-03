using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class GlossaryItem_1302213038
    {
        public void ReadJSON()
        {
            var jsonFolder = File.ReadAllText("E:\\modul7\\jurnal7_3_1302213038.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonFolder);

            foreach (var item in jsonObj.glossary.GlossDiv.GlossList.GlossEntry)
            {
                Console.WriteLine("\n" + item);
            }
        }
    }
}
