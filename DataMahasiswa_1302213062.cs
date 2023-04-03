using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa_1302213062
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText("E:/modul7_kelompok_2/jurnal7_1_1302213062.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);

            string namadepan = jsonObj.firstName;
            string namabelakang = jsonObj.lastName;
            string gender = jsonObj.gender;
            string age = jsonObj.age;
            string streetAdr = jsonObj.address.streetAddress;
            string cityAdr = jsonObj.address.city;
            string stateAdr = jsonObj.address.state;


            Console.WriteLine("Nama " + namadepan + " " + namabelakang + " " + gender + " " + age + " " + streetAdr + " " + cityAdr + " " + stateAdr);
            Console.WriteLine("Mata kuliah yang diambil: ");
            for (int i = 0; i < jsonObj.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {jsonObj.courses[i].code} - {jsonObj.courses[i].name}");
            }
        }
    }
}
