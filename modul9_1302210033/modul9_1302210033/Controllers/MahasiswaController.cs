using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302210033.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Putri Auliya Rahmah","1302210033",new List<string>{"KPL", "BASDAT"},2021 ),
            new Mahasiswa("Hilman Fariz Hirzi","1302213092",new List<string>{"KPL", "BASDAT"},2021),
            new Mahasiswa("Jaatsiyah Maulidina Astrianto","1302213043",new List<string>{"KPL", "SQA"},2021),
            new Mahasiswa("Liyan Made Leon WAYAN","1302213037",new List<string>{"KPL", "PBO"},2021),
            new Mahasiswa("Rihan Hidayat","1302210028",new List<string>{"KPL", "PBO"},2021)
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswa.Add(newMahasiswa);
        }

        // PUT api/<MahasiswaController>/5
        //[HttpPut("{id}")]
        //public void Put(int [FromBody] string value)
        //{

        //}

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}
