using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using JWTWebAPI.Utils.Policies;

namespace JWTWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Authorize(AuthPolicies.ViewUsersPolicy)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Authorize(AuthPolicies.ViewUsersPolicy)]
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "value3" };
        }

        // POST api/values
        [Authorize(AuthPolicies.ManageUsersPolicy)]
        [HttpPost]
        public void Post(string value)
        {
            Console.WriteLine(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [Authorize(AuthPolicies.ManageUsersPolicy)]
        public void Put(int id, [FromBody]string value)
        {
            Console.WriteLine($"value1" + value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [Authorize(AuthPolicies.ManageUsersPolicy)]
        public void Delete(int id)
        {
            Console.WriteLine(id);
        }
    }
}
