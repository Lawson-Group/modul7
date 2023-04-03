using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace modul7_kelompok_2
{
    internal class GlossaryItem_1302213030
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\modul7\jurnal7_3_1302213030.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            foreach (var item in jsonObject.glossary.GlossDiv.GlossList.GlossEntry)
            {
                Console.WriteLine(item);
            }
        }
    }
}
