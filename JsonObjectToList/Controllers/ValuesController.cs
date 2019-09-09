using JsonObjectToList.ModelBinder;
using JsonObjectToList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace JsonObjectToList.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([ModelBinder(typeof(JsonToListModelBinder))]MyModel value)
        {
            return Ok(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]object value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
