using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class TeamMembers_1302213038
    {
        public void ReadJSON()
        {
            var jsonFolder = File.ReadAllText("E:\\modul7\\jurnal7_2_1302213038.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonFolder);

            Console.WriteLine("\nTeam Member List:");
            for (int i = 0; i < jsonObj.members.Count; i++)
            {
                Console.WriteLine(jsonObj.members[i].nim + " " + jsonObj.members[i].firstName 
                    + " " + jsonObj.members[i].lastName + " (" + jsonObj.members[i].age 
                    + ", " + jsonObj.members[i].gender + ")");
            }
        }
    }
}
