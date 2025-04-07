using tpmodul7_kelompok_7;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022330152 mhs = new DataMahasiswa103022330152();
        mhs.ReadJSON();

        KuliahMahasiswa103022330152 kuliah = new KuliahMahasiswa103022330152();
        kuliah.ReadJSON();
    }
}
