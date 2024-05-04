namespace modul10_1302220129
{
    public class Mahasiswa
    {
        public string nama { get; set; }
        public string nim {get; set; }
        public List<string> course {  get; set; } = new List<string>();
        public int year {  get; set; }

        public Mahasiswa(string nama, string nim, List<string> course, int year)
        {
            this.nim = nim;
            this.nama = nama;
            this.year = year;
            this.course = course;
        }
    }
}
