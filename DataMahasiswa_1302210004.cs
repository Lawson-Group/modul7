using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa_1302210004
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"\modul7_kelompok_2\modul7\jurnal7_1_1302210004.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);
            string fnm = jsonObj.firstName;
            string lnm = jsonObj.lastName;
            string gndr = jsonObj.gender;
            string age = jsonObj.age;
            string adrst = jsonObj.address.streetAddress;
            string city = jsonObj.address.city;
            string state = jsonObj.address.state;
            

            Console.WriteLine("Nama " + fnm + " " + lnm + " " + gndr + " " + age + " " + adrst + " " + city + " " + state );
            Console.WriteLine("Mata kuliah yang diambil: ");
            for(int i = 0; i < jsonObj.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {jsonObj.courses[i].code} - {jsonObj.courses[i].name}");
            }
        }
    }
}
