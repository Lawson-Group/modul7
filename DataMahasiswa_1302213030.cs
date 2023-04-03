using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa_1302213030
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\modul7\jurnal7_1_1302213030.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Data mahasiswa: ");
            Console.WriteLine($"Nama\t\t: {jsonObject.firstName}  {jsonObject.lastName} \n" +
                $"Jenis Kelamin\t: {jsonObject.gender} \n" +
                $"Umur\t\t: {jsonObject.age} \n" +
                $"Alamat\t\t: {jsonObject.address.streetAddress}, {jsonObject.address.city}, {jsonObject.address.state}" );

            Console.WriteLine("");

            Console.WriteLine("Mata Kuliah yang diambil: ");
            for ( int i = 0;i < jsonObject.courses.Count; i++ ) {
                Console.WriteLine($"MK {i+1} {jsonObject.courses[i].code} - {jsonObject.courses[i].name}");
            }
        }
    }
}
