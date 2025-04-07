using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class KuliahMahasiswa103022300106
    {
        public List<Course> courses { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_2_103022300106.json");
            KuliahMahasiswa103022300106 data = JsonSerializer.Deserialize<KuliahMahasiswa103022300106>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
