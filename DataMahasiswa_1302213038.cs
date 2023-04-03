using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa_1302213038
    {
        public void ReadJSON()
        {
            var jsonFolder = File.ReadAllText("E:\\modul7\\jurnal7_1_1302213038.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonFolder);

            string namaDepan = jsonObj.firstName;
            string namaBelakang = jsonObj.lastName;
            string gender = jsonObj.gender;
            int age = jsonObj.age;
            string streetAdr = jsonObj.address.streetAddress;
            string cityAdr = jsonObj.address.city;
            string stateAdr = jsonObj.address.state;

            Console.WriteLine("Nama Lengkap\t: " + namaDepan + " " + namaBelakang);
            Console.WriteLine("Jenis Kelamin\t: " + gender);
            Console.WriteLine("Umur\t\t: " + age);
            Console.WriteLine("Alamat\t\t: " + streetAdr + " Street, " + cityAdr 
                + " City, Province of " + stateAdr);

            Console.WriteLine("\nDaftar Mata Kuliah yang Diambil: ");
            for (int i = 0; i < jsonObj.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i+1) + ": " + jsonObj.courses[i].code 
                    + " - " + jsonObj.courses[i].name);
            }
        }
    }
}
