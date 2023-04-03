// See https://aka.ms/new-console-template for more information

using modul7_kelompok_2;

DataMahasiswa_1302213030 dm = new DataMahasiswa_1302213030();
dm.ReadJSON();

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

TeamMembers_1302213030 tm = new TeamMembers_1302213030();
tm.ReadJSON();
