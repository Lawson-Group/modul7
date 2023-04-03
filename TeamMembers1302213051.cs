using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class TeamMembers1302213051
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"E:\modul7_kelompok_2\jurnal7_2_1302213051.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);

            Console.WriteLine("\nTeam member list: ");
            for (int i = 0; i < jsonObj.members.Count; i++)
            {
                Console.WriteLine($"{jsonObj.members[i].nim} " +
                    $"{jsonObj.members[i].firstName} " +
                    $"{jsonObj.members[i].lastName} " +
                    $"{jsonObj.members[i].age} " +
                    $"{jsonObj.members[i].gender}");
            }
        }
    }
}
