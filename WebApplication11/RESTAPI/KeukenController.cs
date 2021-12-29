using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ZDatabaseVerbinding;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication11.RESTAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeukenController : ControllerBase
    {
        private DataBaseContextVerbinding _db;

        public KeukenController(DataBaseContextVerbinding db)
        {
            _db = db;
        }






         // GET: api/<KeukenController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("anders/{koksnaam}")]
        public Kok Get2(string koksnaam)
        {
            Kok k = new Kok();
            k.Naam = koksnaam;
            k.Salaris = 2500;
            _db.Add(k);
            _db.SaveChanges();
           
            return k;
        }
        [HttpGet("allekoks")]
        public IEnumerable<Kok> Get3()
        {
            return _db.koks;
        }
        // GET api/<KeukenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KeukenController>
        [HttpPost]
        public string Post([FromBody] Kok dekok)
        {
            _db.Add(dekok);
            _db.SaveChanges();
            return ">>>"+dekok.Naam;
        }

        // PUT api/<KeukenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KeukenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
