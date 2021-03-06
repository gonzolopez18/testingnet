using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Interfaces.Business;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testingnet.Controllers
{
    [Route("api/[controller]")]
    public class RandomGame : Controller
    {
        private IRandomManager randomManager;

        public RandomGame(IRandomManager randomManager)
        {
            this.randomManager = randomManager ?? throw new ArgumentNullException(nameof(randomManager));
        }


        // GET: api/values
        [HttpGet]
        public IEnumerable<RandomGame> Get()
        {
            return (IEnumerable<RandomGame>)randomManager.GetRandomGames();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

