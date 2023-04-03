using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class TeamMembers_1302210004
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"\modul7_kelompok_2\modul7\jurnal7_2_1302210004.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);
            Console.WriteLine("Daftar Member: ");
            for (int i = 0; i < jsonObj.members.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {jsonObj.members[i].nim} " +
                    $"{jsonObj.members[i].firstName} {jsonObj.members[i].lastName} " +
                    $"{jsonObj.members[i].age} {jsonObj.members[i].gender} ");
            }
        }
    }
}
