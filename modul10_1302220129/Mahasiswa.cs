namespace modul10_1302220129
{
    public class Mahasiswa
    {
        public String nama ( get; set; )
        public String nim (get; set; )
        public List<string> course;
        public int year;

        public Mahasiswa(string nama, string nim)
        {
            this.nim = nim;
            this.nama = nama;
        }

        public void setNama (String nama)
        {
            this.nama = nama;
        }

        public String getNama()
        {
            return nama();
        }

        public String getnim()
        {
            return nim();
        }

        public void setNim(String nim)
        {
            this.nim = nim;
        }

    }
}
