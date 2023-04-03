using modul7_kelompok_2;

class main
{
    public static void Main(String[] args)
    {
        DataMahasiswa_1302210004 Dt = new DataMahasiswa_1302210004();
        Dt.ReadJSON();

        Console.WriteLine(" ");
        TeamMembers_1302210004 Tm = new TeamMembers_1302210004();
        Tm.ReadJSON();

        Console.WriteLine(" ");
        GlossaryItem_1302210004 gi = new GlossaryItem_1302210004();
        gi.ReadJSON();
    }
}