using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApp1.Models;
using TestApp1.Mongos;

namespace TestApp1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            //var mongo = new Mongo();

            //var person = new Person();
            //person.age = 27;
            //person.height = 6;
            //person.name = "vineeth";

            var id = "a330f375-1be2-4080-ad4f-c12c13768986";
            var deleteid = new Mongo();
            deleteid.DeletePerson(id);
            return new string[] { "value1", "value2" };
        }
      

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
