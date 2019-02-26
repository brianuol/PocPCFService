using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PocPCFService.Consumer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            List<string> results = new List<string>();
            using (var client = new Services.PocPCFService("NetTcpBinding_PocPCFService"))
                results.Add(client.GetData(new Random().Next()));
            return results.ToArray();
        }

        // GET api/values/5
        public string Get(int id)
        {
            string value = "";
            using (var client = new Services.PocPCFService("NetTcpBinding_PocPCFService"))
                value = client.GetData(id);
            return value;
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
