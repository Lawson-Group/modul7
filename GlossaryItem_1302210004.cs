using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class GlossaryItem_1302210004
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"\modul7_kelompok_2\modul7\jurnal7_3_1302210004.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);
            Console.WriteLine("Daftar Glossary Item: ");

            foreach (var item in jsonObj.glossary.GlossDiv.GlossList.GlossEntry)
            {
                Console.WriteLine(item);
            }
        }
    }
}
