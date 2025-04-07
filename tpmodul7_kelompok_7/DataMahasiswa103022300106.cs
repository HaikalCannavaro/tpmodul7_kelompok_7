using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    public class DataMahasiswa103022300106
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_1_103022300106.json");
            DataMahasiswa103022300106 data = JsonSerializer.Deserialize<DataMahasiswa103022300106>(jsonString);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
