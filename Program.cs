// See https://aka.ms/new-console-template for more information

using modul7_kelompok_2;

DataMahasiswa1302213051 dataM = new DataMahasiswa1302213051();
dataM.ReadJSON();

TeamMembers1302213051 teamM = new TeamMembers1302213051();
teamM.ReadJSON();

GlossaryItem1302213051 glosI = new GlossaryItem1302213051();
glosI.ReadJSON();

DataMahasiswa_1302210004 Dt = new DataMahasiswa_1302210004();
Dt.ReadJSON();

Console.WriteLine(" ");
TeamMembers_1302210004 Tm = new TeamMembers_1302210004();
Tm.ReadJSON();

Console.WriteLine(" ");
GlossaryItem_1302210004 gi = new GlossaryItem_1302210004();
gi.ReadJSON();
