using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todoAPI.Controllers
{
    public class ToDo
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }
        public bool Completed { get; set; }

        public ToDo(int id, string text, int priority, bool completed)
        {
            ID = id;
            Text = text;
            Priority = priority;
            Completed = completed;
        }
    }

    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public ToDo[] Get()
        {
            return new ToDo[] { };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/values
        [HttpPost("{id, text, priority, completed}")]
        public void Post([FromBody]string value)
        {
            Console.Write(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
