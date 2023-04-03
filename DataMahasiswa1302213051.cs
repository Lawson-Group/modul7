using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa1302213051
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"E:\modul7_kelompok_2\jurnal7_1_1302213051.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);

            string namaDep = jsonObj.firstName;
            string namaBel = jsonObj.lastName;
            string jenKel = jsonObj.gender;
            int umur = jsonObj.age;
            string jalan = jsonObj.address.streetAddress;
            string kota = jsonObj.address.city;
            string prov = jsonObj.address.state;

            Console.WriteLine($"Nama\t\t: {namaDep} {namaBel}");
            Console.WriteLine("Jenis Kelamin\t: " + jenKel);
            Console.WriteLine("Umur\t\t: " + umur);
            Console.WriteLine($"Alamat {jalan} di {kota} Provinsi {prov}\n");

            Console.WriteLine("Daftar mata kuliah yang dipilih: ");
            for(int i = 0; i < jsonObj.courses.Count; i++)
            {
                Console.WriteLine($"Matkul {i+1} {jsonObj.courses[i].code} - {jsonObj.courses[i].name}");
            }

        }
    }
}
