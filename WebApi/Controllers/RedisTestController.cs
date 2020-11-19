using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.HelpServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisTestController : ControllerBase
    {
        // GET: api/<RedisTestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {

       
           var reselt= RedisCacheHelper.GetStringValue("testvalue");//获取数据

            return new string[] { "value", reselt };
        }

        // GET api/<RedisTestController>/5
        [HttpGet("{values}")]
        public string Setvalue(string  values)
        {
            RedisCacheHelper.SetStringValue("testvalue", values);//添加数据
            return values + " ----set ok";
        }

        // POST api/<RedisTestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RedisTestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RedisTestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
