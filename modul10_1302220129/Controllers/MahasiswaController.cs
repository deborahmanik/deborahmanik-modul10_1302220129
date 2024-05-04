using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220129.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("deborah", "1302220129", ["Basis Data", "Dasar Jarkom"], 2022),
            new Mahasiswa("ara", "13022220024", ["kalkulus", "kpl"], 2022),
            new Mahasiswa("haikal", "1302220123", ["pbo", "basdat"], 2022)
        };
        [HttpGet]
       public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }
        [HttpGet("{id}")]

        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody]Mahasiswa mahasiswa) { 
            dataMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
