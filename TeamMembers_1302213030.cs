using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace modul7_kelompok_2
{
    internal class TeamMembers_1302213030
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\modul7\jurnal7_2_1302213030.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Team member list: ");
            for (int i = 0; i < jsonObject.members.Count; i++)
            {
                Console.WriteLine($"{jsonObject.members[i].nim} {jsonObject.members[i].firstName} {jsonObject.members[i].lastName}" +
                    $" {jsonObject.members[i].age} {jsonObject.members[i].gender} ");
            }
        }
    }
}

